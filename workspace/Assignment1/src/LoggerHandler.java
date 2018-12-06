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
	static File LogFile2 = null;
	private LoggerHandler()
	{
		LogFile = new File("Log.txt");
		LogFile1= new File("Log1.txt");
		LogFile2= new File("Log2.txt");
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
				LogFile2.createNewFile();
			}
			catch(Exception e)
			{
				
			}
		}
		return log;
	}
		
	public void addLog(String data)
	{
		try {
			Files.write(Paths.get("Log2.txt"), data.getBytes(), StandardOpenOption.APPEND);
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
		
		
	
}
