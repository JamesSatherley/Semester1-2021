package assignment1;

import java.util.ArrayList;

public class TestPersistency {
    public static void main(String[] args) {
        Course c1 = new Course("159.101", "Introduction to Computing");
        Address a1 = new Address("Palmerston North", "South Street", "4475", 65);
        Student s1 = new Student("George", "Smith", "19004043", "23/05/1994", c1, a1);

        Course c2 = new Course("159.201", "Introduction to Complex Computing"); // create s1 and s2 objects with associated course and address objects
        Address a2 = new Address("Levin", "East Street", "5886", 5);
        Student s2 = new Student("Mike", "McDonald", "20005996", "02/06/1995", c2, a2);


        ArrayList<Student> students = new ArrayList<>();
        students.add(s1);
        students.add(s2); // assign those students to an array

        ArrayList<Student> students_new = new ArrayList<>();

        for (Student s : students) {
            assert s == students.get(students.indexOf(s)) : "true"; // assert that you can write the array out successfully
            students_new.add(s); // assert that you can read the array into a new array successfully
            assert students.get(students.indexOf(s)) == students_new.get(students.indexOf(s)): "true"; // assert that your objects in your two arrays have the same values
        }
    }
}