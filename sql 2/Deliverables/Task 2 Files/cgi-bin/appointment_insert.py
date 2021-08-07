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
data = []
query = ""


try:
    form = cgi.FieldStorage()
    n = form['name'].value if 'name' in form else ''
    d = form['date_in'].value if 'date_in' in form else ''
    doc = form['doctor'].value if 'doctor' in form else ''
    st = form['start_time'].value if 'start_time' in form else ''
    et = form['end_time'].value if 'end_time' in form else ''
    if n != '' or d != '' or doc != '' or st != '' or et != '':
        query = "select insert_check(%s,%s,%s,%s,%s);"
        conn = psycopg2.connect("dbname='158.247' user='158.247-app' host='127.0.0.1' password='foobar'")
        cursor = conn.cursor()
        cursor.execute(query, (n,doc,d,st,et))
        query = "select * from appointments;"
        cursor.execute(query)
        data = cursor.fetchall()
        if len(data) > 0:
            return_html += '<table id="tbl"><tr><th>Date</th><th>Start Time</th><th>End Time</th></tr>'
            return_html += data
            return_html += "</table>"

    else:
        return_html += "<h1>Please enter complete data!</h1>"
    
except psycopg2.Error as e:
    print("Database Error: {}".format(e))
    print("<br>Query: {}".format(e))

print(html_code.format(return_html))

