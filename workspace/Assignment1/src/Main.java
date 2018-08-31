import java.awt.List;
import java.io.BufferedInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class Main 
{

	public static void main(String[] args) 
	{
		Scanner scan = new Scanner(System.in);
		LoggerHandler loggerHandler = LoggerHandler.getInstance();
		int ch;
		do {
			do {
				System.out.println("MENU: \n 1.Enter student details \n2.Enter Employee details  \n0.Press 0 to exit");
				ch = Integer.parseInt(scan.nextLine());
			} while (ch < 0 || ch>2);
			
			switch (ch) {
			case 1:
				//Student student = new Student();
				System.out.print("Enter the person's Id: ");
				int id = Integer.parseInt(scan.nextLine());
				System.out.print("Enter person's first name: ");
				String fname = scan.nextLine();
				System.out.print("Enter person's last name: ");
				String lname = scan.nextLine();
				
				System.out.print("Enter the student Id: ");
				int studentID = Integer.parseInt(scan.nextLine());
				System.out.print("Enter student's first name: ");
				String StudentFirstName = scan.nextLine();
				//student.getSFirstName(StudentFirstName);
				System.out.print("Enter student's last name: ");
				String StudentLastName = scan.nextLine();
				
				new Student(id, fname, lname,studentID,StudentFirstName,StudentLastName);
				break;
				
			case 2:
				//Employee employee = new Employee();
				Employee emp = null;
				ArrayList<Employee> employeeList = new ArrayList<>();
				System.out.println("How many records you want to add??");
				int employeeRecords = Integer.parseInt(scan.nextLine());
				
				for (int i = 0; i < employeeRecords; i++) 
				{
					System.out.print("Enter the Employee Id: ");
					int EmployeeID = Integer.parseInt(scan.nextLine());
					System.out.print("Enter Employee's first name: ");
					String EmployeeFirstName = scan.nextLine();
					System.out.print("Enter Employee's last name: ");
					String EmployeeLastName = scan.nextLine();
					System.out.println("Enter salary:");
					int salary =Integer.parseInt(scan.nextLine());
					emp = new Employee(EmployeeID, EmployeeFirstName, EmployeeLastName,salary);
					employeeList.add(emp);
					
					/*System.out.println("Want to add salary??? 1.Yes 2.No");
					int n = Integer.parseInt(scan.nextLine());
					if(n==1)
					{
						System.out.println("Enter salary:");
						int salary =Integer.parseInt(scan.nextLine());
						emp.setSalary(salary);
					}*/	
					
				}
				loggerHandler.addLog(employeeList.toString());
				emp.FileToList();
				//System.out.println(employeeList);
				//loggerHandler.addLog(employeeList.toString());
			break;
				
			/*case 2:
				//ArrayList<Employee> employeeList = new ArrayList<>();
				
				System.out.print("Enter the Employee Id: ");
				int EmployeeID = Integer.parseInt(scan.nextLine());
				System.out.print("Enter Employee's first name: ");
				String EmployeeFirstName = scan.nextLine();
				System.out.print("Enter Employee's last name: ");
				String EmployeeLastName = scan.nextLine();
				System.out.println("Enter salary:");
				int salary =Integer.parseInt(scan.nextLine());
				Employee emp = new Employee(EmployeeID, EmployeeFirstName, EmployeeLastName,salary);
				if(salary>10000)
				{
					//employeeList.add(emp);
					emp.AddToList(emp);
				}
				//System.out.println(employeeList);
				break;*/
			case 0:
				System.out.println("program ends");
				break;
				
			default:
				System.out.println("Invalid input....");
				break;
			}
					
		} while (ch!=0);	
		
		
		
	}
}
