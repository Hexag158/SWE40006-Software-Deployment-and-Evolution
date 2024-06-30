from flask import Flask, request, redirect, url_for, render_template_string, session
from flask_session import Session  # Flask-Session for server-side session management

app = Flask(__name__)

# Configure session to use filesystem (instead of signed cookies)
app.config["SESSION_PERMANENT"] = False
app.config["SESSION_TYPE"] = "filesystem"
Session(app)

@app.route('/submit', methods=['GET', 'POST'])
def submit():
    if request.method == 'POST':
        # Assuming the input is a comma-separated list of numbers
        numbers_str = request.form['numbers']
        numbers_list = [int(x) for x in numbers_str.split(',')]
        numbers_list.sort()  # Sort the list
        session['sorted_numbers'] = numbers_list  # Store in session
        return redirect(url_for('sorted'))
    # If GET, show the form
    return render_template_string('''
        <form method="post">
            Enter numbers separated by commas: <input type="text" name="numbers">
            <input type="submit">
        </form>
    ''')

@app.route('/sorted')
def sorted():
    sorted_numbers = session.get('sorted_numbers', [])
    return f'Sorted numbers: {sorted_numbers}'

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080)