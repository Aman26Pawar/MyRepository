import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.nio.file.StandardOpenOption;


public class LoggerHandler 
{
	private static LoggerHandler log = null;
	static File file = null;
	private LoggerHandler()
	{
		file = new File("Log.txt");
	}
	public static LoggerHandler getInstance()
	{
		if(log==null)
		{
			log = new LoggerHandler();
			try
			{
				file.createNewFile();
			}
			catch(Exception e)
			{
				
			}
		}
		return log;
	}
	
	/*public void addLog(Student student)
	{
	
		String per = "["+student.PersonID +","+student.PFirstName +","+ student.PLastName+"]"
					+"["+student.StudentID +","+student.SFirstName +","+ student.SLastname+"]";
		try {
			Files.write(Paths.get("Log.txt"), per.getBytes(), StandardOpenOption.APPEND);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}*/
	
	
	public void addLog(Object object)
	{
		//System.out.println(object);
		String str = null;
		if(object.toString() == "class Student")
		{
			System.out.println("Hello");
			Student student = (Student) object;
			str ="["+student.StudentID +","+student.SFirstName +","+ student.SLastname+"]";
			System.out.println(str);
		}
		else if(object.toString() == "class Employee")
		{
			System.out.println("world");
			Employee emp = (Employee) object;
			str = "["+emp.EmployeeID +","+emp.EFirstName +","+ emp.ELastName+"]";
			System.out.println(str);
		}
		
	}
}
