package table;

import javax.annotation.Generated;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;

import org.springframework.web.bind.annotation.RestController;
@RestController
@Entity
public class Teacher {

	private @Id @GeneratedValue int TeacherID;
	private String firstName;
	private String lastName;
	private String userName;
	private String password;
	
	public Teacher(String firstName,String lastName,String userName,String password) 
	{
		this.firstName=firstName;
		this.lastName=lastName;
		this.userName=userName;
		this.password =password;
	}
}
