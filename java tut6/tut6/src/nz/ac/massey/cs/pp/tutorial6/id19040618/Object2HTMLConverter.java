package nz.ac.massey.cs.pp.tutorial6.id19040618;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.List;

public class Object2HTMLConverter {
	void print(List data,Class type,File output) {
		String output_file = "<html>\r\n<body>\r\n<table border=\"1\">\r\n <tr>\r\n  <th>student_id</th>\r\n  <th>first name</th>\r\n  <th>name</th>\r\n  <th>program</th>\r\n  <th>major</th>\r\n </tr>";
		data.remove(0);
		
		while (data.isEmpty() == false) {
			Object firstName = getData(data.get(0), "getFirst_name", type);
			Object surname = getData(data.get(0), "getSurname", type);
			Object id = getData(data.get(0), "getId", type);
			Object program = getData(data.get(0), "getProgram", type);
			Object major = getData(data.get(0), "getMajor", type);
			
			output_file += "\r\n\r\n <tr>\r\n  <td>" + id + "</td>\r\n  <td>" + firstName + "</td>\r\n  <td>" + surname + "</td>\r\n  <td>" + program + "</td>\r\n  <td>" + major + "</td>\r\n </tr>\r\n";
			data.remove(0);
		}
		output_file += "</table>\r\n</body>\r\n</html>";
			
		try {
			FileWriter typer = new FileWriter(output);
			typer.write(output_file);
			typer.close();
			
		} catch (IOException error) {
			System.out.println("Error in file outputing, here is error: " + error);
		}
	}
	
	Object getData(Object o, String s, Class c) {
		Object x = null;
		try {
			Method method = c.getMethod(s);
			x = method.invoke(o);
		} catch (NoSuchMethodException e) {
			System.out.println(e);
		} catch (IllegalAccessException e) {
			System.out.println(e);
		} catch (IllegalArgumentException e) {
			System.out.println(e);
		} catch (InvocationTargetException e) {
			System.out.println(e);
		}
		return x;
	}
}
