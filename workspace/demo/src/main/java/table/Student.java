package table;

import javax.annotation.Generated;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

import org.springframework.lang.NonNull;

public class Student 
{
	private @Id @GeneratedValue int StudentID;
	@NonNull
	private String firstName;
	private String lastName;
	@NonNull
	private int TeacherID;
	@NonNull
	private String classs;
	@NonNull
	private String div;
	@NonNull
	private String line1;
	@NonNull
	private String line2;
	@NonNull
	private int pinCode;
	
	public int getStudentID() {
		return StudentID;
	}
	public void setStudentID(int studentID) {
		StudentID = studentID;
	}
	public String getFirstName() {
		return firstName;
	}
	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}
	public String getLastName() {
		return lastName;
	}
	public void setLastName(String lastName) {
		this.lastName = lastName;
	}
	public int getTeacherID() {
		return TeacherID;
	}
	public void setTeacherID(int teacherID) {
		TeacherID = teacherID;
	}
	public String getClasss() {
		return classs;
	}
	public void setClasss(String classs) {
		this.classs = classs;
	}
	public String getDiv() {
		return div;
	}
	public void setDiv(String div) {
		this.div = div;
	}
	public String getLine1() {
		return line1;
	}
	public void setLine1(String line1) {
		this.line1 = line1;
	}
	public String getLine2() {
		return line2;
	}
	public void setLine2(String line2) {
		this.line2 = line2;
	}
	public int getPinCode() {
		return pinCode;
	}
	public void setPinCode(int pinCode) {
		this.pinCode = pinCode;
	}
	
	public Student() {
		// TODO Auto-generated constructor stub
	}
	
	public Student( String firstName, String lastName, int TeacherID,String classs, String div, String line1, String line2, int pinCode) 
	{
		this.firstName=firstName;
		this.lastName=lastName;
		this.TeacherID=TeacherID;
		this.classs=classs;
		this.div=div;
		this.line1 = line1;
		this.line2 = line2;
		this.pinCode =pinCode;
	}
	

	
}
