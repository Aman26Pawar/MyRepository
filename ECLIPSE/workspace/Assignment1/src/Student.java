
public class Student extends Person
{

	public int StudentID;
	public String SFirstName;
	public String SLastname;
	public Student(int PersonID, String PFirstName, String PLastName,int StudentID,String SFirstName,String SLastname)
	{
		super(PersonID, PFirstName, PLastName);
		this.StudentID = StudentID;
		this.SFirstName = SFirstName;
		this.SLastname = SLastname;
		LoggerHandler logggerHandler = LoggerHandler.getInstance();
		logggerHandler.addLog(getClass());
	}
	
	
}