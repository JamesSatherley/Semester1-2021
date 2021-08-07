package assignment1;

import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener; // imports all the needed imports
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.util.ArrayList;
import java.util.Arrays;

public class StudentListEditor extends JFrame{
    private JButton exitButton;
    private JButton deleteButton;
    private JButton saveButton;
    private JButton loadButton;
    private JButton cloneButton; // defines all gui items and needed data sets
    private JButton publishButton;
    private JButton addButton;
    private JList studentsList;
    private JTextField IDTextField;
    private JTextField FNTextField;
    private JTextField SNTextField;
    private JTextField DOBTextField;
    private JTextField ATextField;
    private JTextField CTextField;
    private JPanel panelMain;
    private ArrayList<Student> students;
    private DefaultListModel listStudentModel;

    public StudentListEditor() {
        super("Student List Editor");                    // sets title for gui
        this.setContentPane(this.panelMain);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // default needed setup method calls/sets
        this.pack();
        students = StudentStorage.load(new File("students.bin")); // loads data
        listStudentModel = new DefaultListModel();                         // defines needed models
        studentsList.setModel(listStudentModel);
        refreshStudents();                                                 // refreshes the student list on gui

        exitButton.addActionListener(new ActionListener() { // exits the program, exits the code with exit code 0
            @Override
            public void actionPerformed(ActionEvent e) {
                setVisible(false); // sets gui invisible
                dispose();
                System.exit(0);
            }
        });

        loadButton.addActionListener(new ActionListener() { // saves data first to not delete data, then loads saved data. Tells user it was successful
            @Override
            public void actionPerformed(ActionEvent e) {
                StudentStorage.save(students, "students.bin");
                students = StudentStorage.load(new File("students.bin"));
                refreshStudents();
                JOptionPane.showMessageDialog(panelMain,
                        "Data has been loaded from students.bin",
                        "Loaded", JOptionPane.WARNING_MESSAGE);
            }
        });

        saveButton.addActionListener(new ActionListener() { // saves edit to current selected student
            @Override
            public void actionPerformed(ActionEvent e) {
                int currentStudent = studentsList.getSelectedIndex(); // gets index of current student
                ArrayList<String> c_inputs = new ArrayList<>(Arrays.asList(CTextField.getText().split(","))); // creates an array splitted by ","'s to get seperate pieces of data
                ArrayList<String> a_inputs = new ArrayList<>(Arrays.asList(ATextField.getText().split(","))); // uses array below for course, address input class instances
                Course temp_course = new Course(c_inputs.get(0), c_inputs.get(1));
                Address temp_address = new Address(a_inputs.get(2), a_inputs.get(1), a_inputs.get(3), Integer.parseInt(a_inputs.get(0))); // uses created instances and more data to define a new student
                Student temp_student = new Student(SNTextField.getText(), FNTextField.getText(), IDTextField.getText(), DOBTextField.getText(), temp_course, temp_address);

                students.set(currentStudent, temp_student); // overwrites previous student
                JOptionPane.showMessageDialog(panelMain,
                        "Student data with code " + students.get(currentStudent).getId() + " has been saved",
                        "Saved", JOptionPane.WARNING_MESSAGE);
                StudentStorage.save(students, "students.bin"); // tells user it was successful and saves incase of power loss or computer damage
                refreshStudents();
            }
        });

        publishButton.addActionListener(new ActionListener() { // saves file "students.bin"
            @Override
            public void actionPerformed(ActionEvent e) {
                StudentStorage.save(students, "students.bin");
                JOptionPane.showMessageDialog(panelMain,
                        "Data has been published to students.bin",
                        "Published", JOptionPane.WARNING_MESSAGE);
            }
        });

        addButton.addActionListener(new ActionListener() { // adds new user if no data is empty
            @Override
            public void actionPerformed(ActionEvent e) {
                int currentStudent = studentsList.getSelectedIndex();
                ArrayList<String> c_inputs = new ArrayList<>(Arrays.asList(CTextField.getText().split(","))); // creates an array splitted by ","'s to get seperate pieces of data
                ArrayList<String> a_inputs = new ArrayList<>(Arrays.asList(ATextField.getText().split(","))); // uses array below for course, address input class instances
                Course temp_course = new Course(c_inputs.get(0), c_inputs.get(1));
                Address temp_address = new Address(a_inputs.get(2), a_inputs.get(1), a_inputs.get(3), Integer.parseInt(a_inputs.get(0))); // uses created instances and more data to define a new student
                Student temp_student = new Student(SNTextField.getText(), FNTextField.getText(), IDTextField.getText(), DOBTextField.getText(), temp_course, temp_address);

                if (!students.get(currentStudent).equals(temp_student)){ // tests if current student NOT equal to add student
                    students.add(temp_student); // if so, adds new student
                    refreshStudents(); // calls refresh to display the student and saves incase of power loss or computer damage and tells user it was successful
                    StudentStorage.save(students, "students.bin");
                    JOptionPane.showMessageDialog(panelMain,
                            "Student with code " + temp_student.getId() + " has been added",
                            "Added", JOptionPane.WARNING_MESSAGE);
                }else {
                    JOptionPane.showMessageDialog(panelMain,
                            "This data is a duplicate of the current user. Use clone instead for a direct copy",
                            "Duplicate", JOptionPane.WARNING_MESSAGE); // otherwise it will tell user to use clone instead
                }
            }
        });

        cloneButton.addActionListener(new ActionListener() { // clones selected student
            @Override
            public void actionPerformed(ActionEvent e) {
                int currentStudent = studentsList.getSelectedIndex();
                try {
                    Student clone = students.get(currentStudent).deepCopy(); //  clones student using clone method in Student class
                    students.add(clone); // adds clone to students, refreshes to show it too, and saves incase of data loss
                    JOptionPane.showMessageDialog(panelMain,
                            "Item successfully cloned",
                            "Cloned", JOptionPane.WARNING_MESSAGE); // shows successful to user
                    refreshStudents();
                    StudentStorage.save(students, "students.bin");

                } catch (CloneNotSupportedException cloneNotSupportedException) {
                    JOptionPane.showMessageDialog(panelMain,
                            "CloneNotSupportedException",
                            "Error", JOptionPane.WARNING_MESSAGE);
                    cloneNotSupportedException.printStackTrace(); // catches clone not supported exception, prints exception and error message to user
                }

            }
        });

        deleteButton.addActionListener(new ActionListener() { // deletes selected student
            @Override
            public void actionPerformed(ActionEvent e) {
                int currentStudent = studentsList.getSelectedIndex();
                if (currentStudent >= 0) {
                    JOptionPane.showMessageDialog(panelMain,
                            "Student with code " + students.get(currentStudent).getId() + " has been deleted",
                            "Deleted", JOptionPane.WARNING_MESSAGE); // if the current student is not nothing, it will remove them from the arraylist and refresh the Jlist, and save incase of data loss
                    students.remove(currentStudent);
                    refreshStudents();
                    StudentStorage.save(students, "students.bin");
                }
            }
        });

        studentsList.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                int currentStudent = studentsList.getSelectedIndex(); // if the user selects another item on the Jlist this code will run
                if (currentStudent >= 0) {                            // it will set the text fields to the selected student using get functions
                    Student s = students.get(currentStudent);
                    Address a = s.getAddress();
                    Course c = s.getCourse();

                    IDTextField.setText(s.getId());
                    FNTextField.setText(s.getFirst_name());
                    SNTextField.setText(s.getSurname());
                    DOBTextField.setText(s.getDob("dd/MM/yyyy"));
                    ATextField.setText(a.getHouse_number() + "," + a.getStreet() + "," + a.getTown() + "," + a.getPost_code());
                    CTextField.setText(c.getNumber() + "," + c.getName());
                }
            }
        });
    }

    public void refreshStudents(){
        listStudentModel.removeAllElements(); // refresh function works via looping through list of students and adds students' first name each loop
        for (Student s : students) {
            listStudentModel.addElement(s.getFirst_name());
        }
    }

    public static void main(String[] args) { // psvm creates the gui, and sets visible
        StudentListEditor GUI = new StudentListEditor();
        GUI.setVisible(true);
    }
}
