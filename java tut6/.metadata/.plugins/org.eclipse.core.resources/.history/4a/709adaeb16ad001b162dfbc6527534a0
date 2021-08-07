package nz.ac.massey.cs.pp.tutorial4.id19040618;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class CSVSorter {
	public static void main(String[] args) throws Exception
	{
		if (check(args[0],args[2]) == false) {
			List<student> STUDENTS = get_students(args[0]);
			List<student> sorted_STUDENTS = sorter(STUDENTS, args[1]); // calls relevant function in correct order using input args
			output(sorted_STUDENTS, args[2]);
		}
	}
	
	public static boolean check(String x, String y) throws Exception 
	{
		if(x.equals(y)) // checks to see if x and y are equal, if so it will throw and exception
		{
			throw new Exception("IllegalArgumentException: Argument " + x + " and " + y + " are the same");
		}
		return false;
	}
	
	public static void output(List<student> out_list, String out_file) 
	{
		String output = "﻿student_id,fname,name,program, major\r\n";
		while (out_list.isEmpty() == false)  // once the students list is empty this will stop looping
		{
			student Student = out_list.get(0); // gets fist item in students list then (below) adds it to output 
			output += Student.getId() + "," + Student.getFname() + "," + Student.getLname() + "," + Student.getProgram() + "," + Student.getMajor() + ",\r\n";
			out_list.remove(0); // removes from list to allow while loop to work
		}
		
		try {
			FileWriter typer = new FileWriter(out_file); // opens the filewriter to write the output html file in a try except loop incase of any possible error
			typer.write(output);                        // done via opening in accordance with input arg array, written, then closed.
			typer.close();
		} catch (IOException error) {
			System.out.println("Error in file outputing, here is error: " + error);
		}
	}
	
	public static List<student> sorter(List<student> students_list, String sort_by) throws Exception
	{	
		students_list.remove(0); // removes the start of the list (could have left this in, but for the sake of professionality, I should not include name of columns)
		if (sort_by.equals("by_id")) 
		{
			students_list = ByIdComparator.sorter(students_list);
		}else if (sort_by.equals("by_firstname")) 
		{
			students_list = ByFirstNameComparator.sorter(students_list); // tests by_x arg, calls relevant function, throws error if incorrect
		}else if (sort_by.equals("by_lastname")) 
		{
			students_list = ByLastNameComparator.sorter(students_list);
		}else if (sort_by.equals("by_program")) 
		{
			students_list = ByProgramComparator.sorter(students_list);
		}else
		{
			throw new Exception("IllegalArgumentException: Argument " + sort_by + " is not handled");
		}
		
		return students_list;
	}
	
	public static List<student> get_students(String csv) 
	{
		List<student> STUDENTS_return = new ArrayList<>(); // defines list to hold student objects from csv database
		File in = new File("students.csv"); // defines input file in accordance with input arg
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
				current.setLname(temp[2]); // using the split by commas temporary data, sets a student instance to the input details from a certain line
				current.setProgram(temp[3]);
				current.setMajor(temp[4]);
				STUDENTS_return.add(current); // adds current student to STUDENTS list
			}
		reader.close();
		} catch (FileNotFoundException error) { // if file not found will tell user
			System.out.println("CSV likely not found, here is the error: " + error);
		}		
		return STUDENTS_return;
	}
}