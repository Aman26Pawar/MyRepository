
public class Student extends Person
{

	private int StudentID;
	private String SFirstName;
	private String SLastname;
	
	public Student(int PersonID, String PFirstName, String PLastName,int StudentID,String SFirstName,String SLastname)
	{
		super(PersonID, PFirstName, PLastName);
		this.StudentID = StudentID;
		this.SFirstName = SFirstName;
		//getSFirstName(SFirstName);
		this.SLastname = SLastname;
		String data = "["+this.StudentID +","+this.SFirstName +","+ this.SLastname+"]";
		LoggerHandler logggerHandler = LoggerHandler.getInstance();
		logggerHandler.addLog(data);
		
	}
	
/*public String GetData()
	{
		//Employee employee = new Employee();
		String data = "["+this.StudentID+","+this.SFirstName+","+this.SLastname+"]";
		//System.out.println("data = "+data );
		return data;
	}*/
/*public String getSFirstName(String name){
		return this.SFirstName;
	}*/
}