package nz.ac.massey.cs.pp.tutorial6.id19040618;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class StudentReader {
	List<Student> fetchStudents(File input)
	{
	List<Student> STUDENTS_return = new ArrayList<>();
	Scanner reader;
	try {
		reader = new Scanner(input);
		while (reader.hasNextLine())
		{
			String data = reader.nextLine();
			String[] temp = data.split(",");
			Student student = new Student(temp[2],temp[1],temp[0],temp[3],temp[4]);
			STUDENTS_return.add(student);
		}
	reader.close();
	} catch (FileNotFoundException error) {
		System.out.println("CSV likely not found, here is the error: " + error);
	}		
	return STUDENTS_return;
	}
}
