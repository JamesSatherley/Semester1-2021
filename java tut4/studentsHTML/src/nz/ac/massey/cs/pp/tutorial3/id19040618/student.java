package nz.ac.massey.cs.pp.tutorial3.id19040618;

public class student {
	private String id, fname, lname, program, major; // defines privates
	
	public String getId() {return id;}
	public void setId(String id) {this.id = id;}

	public String getFname() {return fname;}
	public void setFname(String fname) {this.fname = fname;} // defines all needed set and get functions for each student instance

	public String getLname() {return lname;}
	public void setLname(String lname) {this.lname = lname;} // of course this could be done in a constructor but this is best practice (atleast i think it is in c++)

	public String getProgram() {return program;}
	public void setProgram(String program) {this.program = program;}

	public String getMajor() {return major;}
	public void setMajor(String major) {this.major = major;}
}
