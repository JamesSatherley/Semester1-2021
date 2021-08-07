import sys
sys.path.append("H:\\apps\\Python27\\lib\\site-packages")
import cgi
import psycopg2

print("Content-type: text/html\n")
print("<title>Login Result</title>")
print("<body><center>")

try:
    form = cgi.FieldStorage()
    name = form['name'].value if 'name' in form else ''
    pwd = form['pwd'].value if 'pwd' in form else ''
    permissions = []
    query = "select permissions from users where name=%s and pwd=%s"
    conn = psycopg2.connect("dbname='158.247' user='158.247-app' host='127.0.0.1' password='foobar'")
    cursor = conn.cursor()
    cursor.execute(query, (name, pwd))
    permissions = cursor.fetchall()

    if len(permissions) > 0:
        print("<H1>Access granted. You have the following permissions: {}.</H1>".format(permissions[0][0]))
    else:
        print("<H1>Access denied.</H1>")
    
except psycopg2.Error as e:
    print("Database Error: {}".format(e))
    print("<br>Query: {}".format(query))
print("""
<form action="../login.html" method="GET">
    <input type="submit" value="Back to Login">
</form>
""")
print('</center></body>')
