package Entity;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="studentinfo")
public class Student implements Serializable
{
	@Id
	@GeneratedValue
	@Column(name="StudentID")
	private int studentID;
	@Column(name="firstName")
	private String firstName;
	@Column(name="lastName")
	private String lastName;
	@Column(name="TeacherID")
	private int teacherID;
	@Column(name="Standard")
	private String standard;
	@Column(name="Division")
	private String division;
	@Column(name="Line1")
	private String addressLine1;
	@Column(name="Line2")
	private String addressLine2;
	@Column(name="PinCode")
	private int pinCode;
	
	public int getStudentID() {
		return studentID;
	}
	public void setStudentID(int studentID) {
		this.studentID = studentID;
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
		return teacherID;
	}
	public void setTeacherID(int teacherID) {
		this.teacherID = teacherID;
	}
	public String getStandard() {
		return standard;
	}
	public void setStandard(String standard) {
		this.standard = standard;
	}
	public String getDivision() {
		return division;
	}
	public void setDivision(String division) {
		this.division = division;
	}
	public String getAddressLine1() {
		return addressLine1;
	}
	public void setAddressLine1(String addressLine1) {
		this.addressLine1 = addressLine1;
	}
	public String getAddressLine2() {
		return addressLine2;
	}
	public void setAddressLine2(String addressLine2) {
		this.addressLine2 = addressLine2;
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
	
	
	public Student(String firstName, String lastName, int teacherID, String standard, String division, String line,
			String line2)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.teacherID = teacherID;
		this.standard = standard;
		this.division = division;
		this.addressLine1 = line;
		this.addressLine2 = line2;
	}
}
