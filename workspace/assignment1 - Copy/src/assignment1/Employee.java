package assignment1;


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
	public int getSalary() {
		return Salary;
	}
	public void setSalary(int salary) {
		Salary = salary;
	}
	

	LoggerHandler loggerHandler = LoggerHandler.getInstance();
	public Employee(int EmployeeID, String EFirstName, String ELastName) 
	{
		this.EmployeeID = EmployeeID;
		this.EFirstName = EFirstName;
		this.ELastName = ELastName;
		String data = "["+this.EmployeeID +","+this.EFirstName +","+ this.ELastName+"]";
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
	@Override
	public String toString() {
		return "Employee [id=" +EmployeeID + ", name=" + EFirstName+" "+ELastName + ", salary=" + Salary + "]";
	}
	
	public int GetEmployeeSalary(int salary)
	{
		/*Scanner scan = new Scanner(System.in);
		System.out.println("Enter salary:");
		int salary = scan.nextInt();*/
		return this.Salary = salary;
	}
}
