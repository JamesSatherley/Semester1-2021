package nz.ac.massey.cs.pp.tutorial3.id19040618;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CSV2HTMLConverter {
	public static void main(String[] args)
	{
		List<student> STUDENTS = new ArrayList<>(); // defines list to hold student objects from csv database
		String output = ""; // defines output string (for html)
		File in = new File(args[0]); // defines input file in accordance with input arg
		Scanner reader;  // opens a reader object
		
		try { // try catch for reader if file not found
			reader = new Scanner(in); // reads input file
			while (reader.hasNextLine())  // while there is a new line below code will loop
			{
				String data = reader.nextLine(); // gets data from the reader
				String[] temp = data.split(","); // splits data by commas into a list of strings
				student current = new student(); // creates new student instance
				
				current.setId(temp[0]);
				current.setFname(temp[1]);
				current.setLname(temp[2]); // using the split by commas temp data, sets a student instance to the input details from a certain line
				current.setProgram(temp[3]);
				current.setMajor(temp[4]);
				
				STUDENTS.add(current); // adds current student to STUDENTS list
			}
		reader.close();
		} catch (FileNotFoundException error) { // if file not found will tell user
			System.out.println("CSV likely not found, here is the error: " + error);
		}
		
		STUDENTS.remove(0); // removes the start of the list (could have left this in, but for the sake of professionality, I should not include name of columns)
		output += "<html>\r\n<body>\r\n<table border=\"1\">\r\n <tr>\r\n  <th>student_id</th>\r\n  <th>first name</th>\r\n  <th>name</th>\r\n  <th>program</th>\r\n  <th>major</th>\r\n </tr>"; // adds html to the start of the output file

		while (STUDENTS.isEmpty() == false)  // once the students list is empty this will stop looping
		{
			student Student = STUDENTS.get(0); // gets fist item in students list then (below) adds it to output 
			output += "\r\n\r\n <tr>\r\n  <td>" + Student.getId() + "</td>\r\n  <td>" + Student.getFname() + "</td>\r\n  <td>" + Student.getLname() + "</td>\r\n  <td>" + Student.getProgram() + "</td>\r\n  <td>" + Student.getMajor() + "</td>\r\n </tr>\r\n";
			STUDENTS.remove(0); // removes from list to allow while loop to work
		}
		
		output += "</table>\r\n</body>\r\n</html>";  // finishes html output
		
		try {
			FileWriter typer = new FileWriter(args[1]); // opens the filewriter to write the output html file in a try except loop incase of any possible error
			typer.write(output);                        // done via opening in accordance with input arg array, written, then closed.
			typer.close();
		} catch (IOException error) {
			System.out.println("Error in file outputing, here is error: " + error);
		}
	}
}
