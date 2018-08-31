package assignment1;

import java.io.FileReader;
import java.text.ParsePosition;
import java.util.Scanner;

public class Person
{
	public int PersonID;
	public String PFirstName;
	public String PLastName;
	
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
