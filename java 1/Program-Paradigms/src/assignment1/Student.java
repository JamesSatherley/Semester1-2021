package assignment1;

import java.io.Serial;
import java.io.Serializable;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter; // import need items
import java.util.Objects;

public class Student implements Serializable {
    @Serial
    private static final long serialVersionUID = 1L; // defines all needed privates, including serial number
    private String surname, first_name, id;
    private LocalDate dob;
    private Course course;
    private Address address;

    public Student(String surname, String first_name, String id, LocalDate dob, Course course, Address address) {
        this.surname = surname;
        this.first_name = first_name;
        this.id = id;
        this.dob = dob;
        this.course = course;       // two constructors, one for when dob is only a string, and needs to be converted into a Date type
        this.address = address;     // so overloaded using setDob overload
    }

    public Student(String surname, String first_name, String id, String dob, Course course, Address address) {
        this.surname = surname;
        this.first_name = first_name;
        this.id = id;
        this.setDob(dob);
        this.course = course;
        this.address = address;
    }

    @Override
    public boolean equals(Object o) { // auto equals definition
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Student student = (Student) o;
        return surname.equals(student.surname) && first_name.equals(student.first_name) && id.equals(student.id) && dob.equals(student.dob) && course.equals(student.course) && address.equals(student.address);
    }

    @Override // auto hash definition
    public int hashCode() {
        return Objects.hash(surname, first_name, id, dob, course, address);
    }

    public Student deepCopy() throws CloneNotSupportedException { // clones current student and makes deep copy of address using address clone method
        Student clone = new Student(this.surname, this.first_name, this.id, this.dob, this.course, this.address.clone());
        return clone;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getFirst_name() {
        return first_name;
    }

    public void setFirst_name(String first_name) { // setters and getters
        this.first_name = first_name;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public LocalDate getDob() {
        return dob;
    }

    public String getDob(String format) {
        return dob.format(DateTimeFormatter.ofPattern(format)); // overloaded getdob for string
    }

    public void setDob(LocalDate dob) {
        this.dob = dob;
    }

    public void setDob(String dob) { this.dob = LocalDate.parse(dob, DateTimeFormatter.ofPattern("dd/MM/yyyy")); } // overloaded setdob for string, sets string to localDate using parse

    public Course getCourse() {
        return course;
    }

    public void setCourse(Course course) {
        this.course = course;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }
}
