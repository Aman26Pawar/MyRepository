import java.util.Scanner;

public class Employee
{
	private int EmployeeID;
	private String EFirstName;
	private String ELastName;
	private int Salary;

	
	public Employee(int EmployeeID, String EFirstName, String ELastName,int ESalary) 
	{
		this.EmployeeID = EmployeeID;
		this.EFirstName = EFirstName;
		this.ELastName = ELastName;
		String data = "["+this.EmployeeID +","+this.EFirstName +","+ this.ELastName+","+GetEmployeeSalary(ESalary)+"]";
		LoggerHandler loggerHandler = LoggerHandler.getInstance();
		loggerHandler.addLog(data);
		//loggerHandler.checkInstance(this);
	}
/*public String GetData()
	{
		//Employee employee = new Employee();
		String data = "["+this.EmployeeID+","+this.EFirstName+","+this.ELastName+","+GetEmployeeSalary()+"]";
		//System.out.println("data = "+data );
		return data;
	}*/
	public int GetEmployeeSalary(int salary)
	{
		/*Scanner scan = new Scanner(System.in);
		System.out.println("Enter salary:");
		int salary = scan.nextInt();*/
		return this.Salary = salary;
	}
}
