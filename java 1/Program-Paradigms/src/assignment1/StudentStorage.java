package assignment1;

import java.io.*;
import java.util.ArrayList; // imports needed imports

public class StudentStorage {
    static void save(ArrayList<Student> list, java.io.File file) // outputs file in binary format
    {
        try {
            FileOutputStream fos = new FileOutputStream(file); // creates output stream, writes object to .bin file, closes stream
            ObjectOutputStream oos = new ObjectOutputStream(fos);
            oos.writeObject(list);
            oos.close();
        } catch (IOException e) { // catches any possible error, prints it too
            System.out.println("Error, likely saving to file, more data here: " + e);
        }
    }

    static void save(ArrayList<Student> list, String fileName) // overloaded function incase file is not defined and uses string instead
    {
        File file = new File(fileName); // defines file and calls save with it
        save(list, file);
    }

    static ArrayList<Student> load(File file) // loads .bin file
    {
        ArrayList<Student> outputList = new ArrayList<>(); // defines return list

        try {
            FileInputStream fis = new FileInputStream(file);
            ObjectInputStream ois = new ObjectInputStream(fis); // creates input stream, reads object, saves as array list, closes stream
            outputList = (ArrayList<Student>) ois.readObject();
            ois.close();

        } catch (FileNotFoundException e) { // catches all different errors and prints them
            System.out.println("Error, likely finding file to load from, more data here: " + e);
        } catch (IOException e) {
            System.out.println("Error, likely processing file to load from, more data here: " + e);
        } catch (ClassNotFoundException e) {
            System.out.println("Error, likely defining class, more data here: " + e);
        }
        return outputList; // finally returns array list of students
    }
}
