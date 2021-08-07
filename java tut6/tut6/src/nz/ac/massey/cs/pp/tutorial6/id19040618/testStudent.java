package nz.ac.massey.cs.pp.tutorial6.id19040618;

import java.io.File;
import java.util.List;

public class testStudent {
	public static void main(String args[]) {
		File input = new File(args[0]);
		File output = new File(args[1] );
	
		StudentReader reader = new StudentReader();
		List<Student> data = reader.fetchStudents(input);
	
		Object2HTMLConverter converter = new Object2HTMLConverter(); 
		converter.print(data, Student.class, output);
	}
}
