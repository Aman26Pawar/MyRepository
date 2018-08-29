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
	static File LogFile = null;
	static File LogFile1 = null;
	private LoggerHandler()
	{
		LogFile = new File("Log.txt");
		LogFile1= new File("Log1.txt");
	}
	public static LoggerHandler getInstance()
	{
		if(log==null)
		{
			log = new LoggerHandler();
			try
			{
				LogFile.createNewFile();
				LogFile1.createNewFile();
			}
			catch(Exception e)
			{
				
			}
		}
		return log;
	}
		
	public void addLog(String data)
	{
		//System.out.println(data);
		try {
			Files.write(Paths.get("Log1.txt"), data.getBytes(), StandardOpenOption.APPEND);
		} catch (IOException e) {
			e.printStackTrace();
		}
		try {
			String content = new String(Files.readAllBytes(Paths.get("Log1.txt")));
			System.out.println(content);
		} catch (IOException e) {
		e.printStackTrace();
		}
	}
	
		/*public void checkInstance(Object object)
		{
			//System.out.println("checkLog " + object);
			if(object instanceof Student)
			{
				//System.out.println("Hello");
				Student student = (Student) object;
				String studentData = student.GetData();
				addLog(studentData);
			}
			else if(object instanceof Employee)
			{
				Employee emp = (Employee) object;
				String employeeData = emp.GetData();
				addLog(employeeData);
			}
		}*/
		
	
}
