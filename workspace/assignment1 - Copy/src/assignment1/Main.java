package assignment1;
import java.util.ArrayList;
import java.util.Scanner;

public class Main 
{

	public static void main(String[] args) 
	{
		Scanner scan = new Scanner(System.in);
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
				ArrayList<Employee> allEmployees = new ArrayList<>();
				System.out.println("Enter no of employes : " );
				int records = Integer.parseInt(scan.nextLine());
							
				for (int i = 0; i < records; i++) 
				{
					System.out.print("Enter the Employee Id: ");
					int EmployeeID = Integer.parseInt(scan.nextLine());
					System.out.print("Enter Employee's first name: ");
					String EmployeeFirstName = scan.nextLine();
					System.out.print("Enter Employee's last name: ");
					String EmployeeLastName = scan.nextLine();
					
					Employee employee = new Employee(EmployeeID,EmployeeFirstName,EmployeeLastName);
				
					System.out.print("Wish to enter salary : 1.YES   2.NO ");
					int choice = Integer.parseInt(scan.nextLine());
					
					
					if(choice == 1){
						System.out.println("Enter salary : ");
						int salary = Integer.parseInt(scan.nextLine());
						employee.setSalary(salary);
					}
					allEmployees.add(employee);
				}
								

				System.out.println("all emp : "  + allEmployees);
				break;
			case 0:
				break;
				
			default:
				System.out.println("Invalid input....");
				break;
			}
					
		} while (ch!=0);	
	}
}
