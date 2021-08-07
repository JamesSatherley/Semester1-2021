package java3;

//Tutorial 1, 159272. Task 3.
public class Village {
	
	public static void main(String[] args) {
		Person Bob = new Person("Johnson", "Bob", 23, 1998, "Spagetti");
		Person Mary = new Person("Benson", "Mary", 22, 1999, "Pad Thai");  // hardcoded people
		Person Jeremy = new Person("Jefferson", "Jeremy", 28, 1993, "McDonalds'");
		
		Mary.changeSurname("Johnson"); // Mary and bob get married

		System.out.println(Bob.toString());
		System.out.println(Mary.toString()); // print out the toString() for each person
		System.out.println(Jeremy.toString());
	}	
}

class Person {
	private String surname;
	private String first_name; // private variables defined
	private int age;
	private int year;
	private String fav_food;
	
	public Person (String surname, String first_name, int age, int year, String fav_food) {
		this.surname = surname;
		this.first_name = first_name; // constructor function
		this.age = age;
		this.year = year;
		this.fav_food = fav_food;
	}
	
	public void changeSurname(String newSurname) { // set function, should have set get for everything
	    surname = newSurname;                      // but was not requested
	}
	
	public String toString() {                     // output toString() function, prints all data in good manner
		return first_name + " " + surname + ": Aged " + String.valueOf(age) + " and born in the year " + String.valueOf(year) + ", loves to eat " + fav_food;
	}
}