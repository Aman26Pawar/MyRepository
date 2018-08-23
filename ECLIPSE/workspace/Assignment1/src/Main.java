import java.util.Scanner;

public class Main {

	public static void main(String[] args) 
	{
		Scanner scan = new Scanner(System.in);
		int ch;
		do {
			do {
				System.out.println("MENU: \n 1.Enter Person's details \n2.Enter Student's details \n0.Press 0 to exit");
				ch = scan.nextInt();
			} while (ch < 0 || ch>2);
			
			switch (ch) {
			case 1:
				System.out.print("Enter the person's Id: ");
				int id = 0;
				
				try {
					id = Integer.parseInt(scan.nextLine());
				} catch (NumberFormatException e) {
					e.printStackTrace();
				}
				//int id =  scan.nextInt();
				System.out.print("Enter person's first name: ");
				String fname = scan.nextLine();
				System.out.print("Enter person's last name: ");
				String lname = scan.nextLine();
				Person person = new Person(id, fname, lname);
				break;

			case 2:
				System.out.print("Enter the student Id: ");
				int studentID =  Integer.parseInt(scan.nextLine());
				System.out.print("Enter student's first name: ");
				String StudentFirstName = scan.nextLine();
				System.out.print("Enter student's last name: ");
				String StudentLastName = scan.nextLine();
				Student student = new Student(studentID, StudentFirstName, StudentLastName);
				break;
				
			case 0:
				break;
				
			default:
				System.out.println("Invalid input....");
				break;
			}
					
		} while (ch!=0);
		
		/*menuloop:
		while (true) {
			switch (ch) {
			case 1:
				System.out.print("Enter the person's Id: ");
				int id =  Integer.parseInt(scan.nextLine());
				//int id =  scan.nextInt();
				System.out.print("Enter person's first name: ");
				String fname = scan.nextLine();
				System.out.print("Enter person's last name: ");
				String lname = scan.nextLine();
				Person person = new Person(id, fname, lname);
				break;

			case 2:
				System.out.print("Enter the student Id: ");
				int studentID =  Integer.parseInt(scan.nextLine());
				System.out.print("Enter student's first name: ");
				String StudentFirstName = scan.nextLine();
				System.out.print("Enter student's last name: ");
				String StudentLastName = scan.nextLine();
				Student student = new Student(studentID, StudentFirstName, StudentLastName);
				break;
				
			case 0:
				break menuloop;
				
			default:
				System.out.println("Invalid input....");
				return;
			}
			
		}*/
		
	}
}
