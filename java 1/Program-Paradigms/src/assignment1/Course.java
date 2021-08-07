package assignment1;

import java.io.Serial;
import java.io.Serializable; // imports need items
import java.util.Objects;

public class Course implements Serializable {
    @Serial
    private static final long serialVersionUID = 2L; // defines all needed privates, including serial number
    private String number, name;

    public Course(String number, String name) { // constructor function
        this.number = number;
        this.name = name;
    }

    @Override
    public boolean equals(Object o) { // auto equals definition
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Course course = (Course) o;
        return Objects.equals(number, course.number) && Objects.equals(name, course.name);
    }

    @Override // auto hash definition
    public int hashCode() { return Objects.hash(number, name); }

    public String getNumber() { return number; }

    public void setNumber(String number) { this.number = number; } // setters and getters

    public String getName() { return name; }

    public void setName(String name) { this.name = name; }
}
