package assignment1_1;

public class Person {
	public int PersonID;
	public String PFirstName;
	public String PLastName;
	
	public Person(int PersonID ,String PFirstName,String PLastName)
	{
		this.PersonID = PersonID ;
		this.PFirstName = PFirstName;
		this.PLastName = PLastName;
		/*LoggerHandler log = LoggerHandler.getInstance();
		log.createLog(this);*/
	}	

}
