package table;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

import org.springframework.lang.NonNull;

@Entity
@Table(name ="TeacherInfo")
public class Teacher {

	private @Id @GeneratedValue int TeacherID;
	@NonNull
	private String firstName;
	@NonNull
	private String lastName;
	@NonNull
	private String userName;
	@NonNull
	private String password;
	
	public Teacher() {
	
	}
	
	
	public int getTeacherID() {
		return TeacherID;
	}


	public void setTeacherID(int teacherID) {
		TeacherID = teacherID;
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


	public String getUserName() {
		return userName;
	}


	public void setUserName(String userName) {
		this.userName = userName;
	}


	public String getPassword() {
		return password;
	}


	public void setPassword(String password) {
		this.password = password;
	}


	public Teacher(String firstName,String lastName,String userName,String password) 
	{
		this.firstName=firstName;
		this.lastName=lastName;
		this.userName=userName;
		this.password =password;
	}
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "Teacher{"+ "name= "+ firstName + " "+ lastName + " user name = "+ userName+ " password= "+password+" }";
	}
}
