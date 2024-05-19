using System;
using Hello;
using Goodbye;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private TextBox textBox;
        private Button button;
        public Form1()
        {
            InitializeComponent();
            this.textBox = new TextBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloDLL hello = new HelloDLL();
            string result = hello.Hellouser(textBox1.Text);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoodbyeDLL Goodbye = new GoodbyeDLL();
            string result = Goodbye.Goodbyeuser(textBox1.Text);
            MessageBox.Show(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
