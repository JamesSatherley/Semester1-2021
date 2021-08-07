package assignment1;

public class TestCloningStudents {
    public static void main(String[] args) {
        Course c1 = new Course("159.101", "Introduction to Computing"); // create your s1 student, with a course and an address
        Address a1 = new Address("Palmerston North", "South Street", "4475", 65);
        Student s1 = new Student("George", "Smith", "19004043", "23/05/1994", c1, a1);

        Student s2 = null;
        try {
            s2 = s1.deepCopy();
        } catch (CloneNotSupportedException e) {
            System.out.println("Clone error; " + e); // clone your student as s2
        }

        s2.getAddress().setStreet("North Street");                      // change a field in address of s2
        s2.getCourse().setName("Introduction to Computing and Coding"); // change the course name in course of s2
        s2.getAddress().setHouse_number(55);                            // change a primitive attrib in s2

        assert s1.getAddress() == a1 : "true"; // assert s1's address field is still original value
        assert s2.getAddress() != a1 : "true"; // assert s2's address field is new value
        assert s1.getCourse().getName() == s2.getCourse().getName() : "true"; // assert s1's course name is the same as s2's course name
        assert s1.getCourse() == s2.getCourse() : "true"; // assert s1's course object is same as s2's course object
        assert s1.getAddress() != s2.getAddress() : "true"; // assert s1's address object is not the same as s2's address object
    }
}