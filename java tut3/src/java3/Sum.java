package java3;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class Sum {
	public static void main(String[] args) {
		
		float total = 0f;
		
		try {
			File txt = new File("Numbers.txt");
			Scanner reader = new Scanner(txt); // import the file 
			while (reader.hasNextLine()) { // loop through the file while there's still more
				
				String data = reader.nextLine();
				String[] splitted = data.split(" "); // split the file by spaces
				int i;
				
				for(i = 0; i < splitted.length; i++) { // add each in a for loop of each line
					try {                              // while checking for errors
						total += Float.parseFloat(splitted[i]);
					}catch(NumberFormatException error) {
						System.out.println(splitted[i] + " cannot be parsed to int; " + error);
					}
				}
			}
			
			reader.close();  // prints total
			System.out.println("Total is: " + String.format("%.4f", total));
			
	    } catch (FileNotFoundException error) { // error catch for missing file
	    	System.out.println("File likely not found, here is the error: " + error);
	    }
	}
}
