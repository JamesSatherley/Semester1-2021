import sys
sys.path.append("H:\\apps\\Python27\\lib\\site-packages")
import cgi
import psycopg2

html_code = """
<!DOCTYPE html>
    <head>
        <title>Result</title>
        <meta charset="utf-8"/>
        <link rel="stylesheet" href="../style.css"/>
    </head>

    <body>
        <div class="center">
            {}
            <form action="../appointment.html" method="GET">
                <input type="submit" value="Back to appointment">
            </form>
        </div>
    </body>
</html>"""
return_html = ""
newAppointment = """
            <form action="appointment_insert.py" method="POST">
                <input type="text" name="name" value="Name" size=40>
                <input type="text" name="doctor" value="Doctor" size=40>
                <h1>Date</h1>
                <input type="date" name="date_in" value="" size=40>
                <h1>Start Time</h1>
                <input type="time" name="start_time" value="" size=40>
                <h1>End Time</h1>
                <input type="time" name="end_time" value="" size=40>
                <input type="submit" value="Create Appointment">
            </form>
            """
data = []


try:
    form = cgi.FieldStorage()
    start = form['start_date'].value if 'start_date' in form else ''
    end = form['end_date'].value if 'end_date' in form else ''
    if start != '':
        query = "SELECT dates_between(%s,%s);"
        conn = psycopg2.connect("dbname='158.247' user='158.247-app' host='127.0.0.1' password='foobar'")
        cursor = conn.cursor()
        cursor.execute(query, (start, end))
        data = cursor.fetchall()
        if len(data) > 0:
            return_html += '<table id="tbl"><tr><th>Date</th><th>Start Time</th><th>End Time</th></tr>'
            for i in data:
                x = str(i).strip("'[()]'").split(",")
                return_html += "<tr><td>{}</td><td>{}</td><td>{}</td></tr>".format(x[0], x[1], x[2].strip(")'"))
            return_html += "</table>"
            return_html += newAppointment
        else:
            return_html += "<h1>No bookings or avaliability found between these dates</h1>"

    else:
        return_html += "<h1>Please enter complete data!</h1>"
    
except psycopg2.Error as e:
    print("Database Error: {}".format(e))
    print("<br>Query: {}".format(query))

print(html_code.format(return_html))

