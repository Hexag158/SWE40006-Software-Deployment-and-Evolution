FROM python:latest

WORKDIR /app

ADD . /app

RUN pip install --trusted-host pypi.python.org -r requirements.txt

EXPOSE 8080

ENV NAME World

CMD ["python", "app.py", "-p", "8080"]