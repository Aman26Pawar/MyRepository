import java.io.FileReader;
import java.text.ParsePosition;
import java.util.Scanner;

public class Person
{
	private int PersonID;
	private String PFirstName;
	private String PLastName;
	
	public Person() {
		// TODO Auto-generated constructor stub
	}
	public Person(int PersonID ,String PFirstName,String PLastName)
	{
		this.PersonID = PersonID ;
		this.PFirstName = PFirstName;
		this.PLastName = PLastName;
		System.out.println("Person's details: "+ this.PersonID +"," +this.PFirstName+","+this.PLastName);
		/*LoggerHandler logggerHandler = LoggerHandler.getInstance();
		logggerHandler.addLog(this);*/
	}	
}
