package nz.ac.massey.cs.pp.tutorial6.id19040618;

public class Student {
	private String surname, first_name, id, program, major;

	public Student(String surname, String first_name, String id, String program, String major) {
		super();
		this.surname = surname;
		this.first_name = first_name;
		this.id = id;
		this.program = program;
		this.major = major;
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

	public void setFirst_name(String first_name) {
		this.first_name = first_name;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getProgram() {
		return program;
	}

	public void setProgram(String program) {
		this.program = program;
	}

	public String getMajor() {
		return major;
	}

	public void setMajor(String major) {
		this.major = major;
	}
}
