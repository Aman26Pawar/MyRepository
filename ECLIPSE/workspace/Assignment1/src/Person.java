import java.io.FileReader;
import java.text.ParsePosition;
import java.util.Scanner;

public class Person {
	public int PersonID;
	public String PFirstName;
	public String PLastName;
	
	public Person(int PersonID ,String PFirstName,String PLastName)
	{
		this.PersonID = PersonID ;
		this.PFirstName = PFirstName;
		this.PLastName = PLastName;
		LoggerHandler log = LoggerHandler.getInstance();
		log.createLog(this);
	}	
	
	/*public String getFirstName(){
		return PFirstName;
	}
	public String getLastName(){
		return PLastName;
	}*/
}
