package assignment1;

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
	
	
	public void addLog(String data)
	{
		//System.out.println(data);
		try {
			Files.write(Paths.get("Log.txt"), data.getBytes(), StandardOpenOption.APPEND);
		} catch (IOException e) {
			e.printStackTrace();
		}
		try {
			String content = new String(Files.readAllBytes(Paths.get("Log.txt")));
			System.out.println(content);
		} catch (IOException e) {
		e.printStackTrace();
		}
	}


}