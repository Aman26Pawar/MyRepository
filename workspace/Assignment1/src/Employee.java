import java.io.BufferedInputStream;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.Scanner;

public class Employee
{
	private int EmployeeID;
	private String EFirstName;
	private String ELastName;
	private int Salary;
	
	public int getEmployeeID() {
		return EmployeeID;
	}
	public void setEmployeeID(int employeeID) {
		EmployeeID = employeeID;
	}
	public String getEFirstName() {
		return EFirstName;
	}
	public void setEFirstName(String eFirstName) {
		EFirstName = eFirstName;
	}
	public String getELastName() {
		return ELastName;
	}
	public void setELastName(String eLastName) {
		ELastName = eLastName;
	}
	public int getEmployeeSalary() {
		return Salary;
	}
	public void setSalary(int salary) {
		Salary = salary;
	}
	
	LoggerHandler loggerHandler = LoggerHandler.getInstance();
	Scanner scan = new Scanner(System.in);
	ArrayList<Employee> employeeList = new ArrayList<>();
	ArrayList<String> employeeList2 = new ArrayList<>();
	public Employee(int EmployeeID, String EFirstName, String ELastName,int salary) 
	{
		this.EmployeeID = EmployeeID;
		this.EFirstName = EFirstName;
		this.ELastName = ELastName;
		this.Salary = salary;
		/*String data = "["+this.EmployeeID +","+this.EFirstName +","+ this.ELastName+","+this.Salary+"]";
		loggerHandler.addLog(data);*/
	}

	public void FileToList()
	{
		ArrayList<String> fileToList = null;
		try {
			Scanner fileData = new Scanner(new File("Log2.txt"));
			fileToList = new ArrayList<>();
			while(fileData.hasNextLine()){
				fileToList.add(fileData.next());
			}
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		System.out.println(fileToList);
	}
	/*public void AddToList(Object object)
	{
			employeeList.add((Employee) object);
		Collections.copy(employeeList, empLess10k);
		//System.out.println(employeeList);
			for (int i = 0; i < employeeList.size(); i++) 
			{
				System.out.println(employeeList.get(i));
			}
	}*/
	@Override
	public String toString() 
	{
		return  "["+this.EmployeeID +","+this.EFirstName +" "+ this.ELastName+","+this.Salary+"]";
	}
	
	

}
