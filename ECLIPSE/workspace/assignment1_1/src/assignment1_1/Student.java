package assignment1_1;

public class Student extends Person {
	public Student(int PersonID, String PFirstName, String PLastName) {
		super(2, "Aman", "Pawar");
		// TODO Auto-generated constructor stub
		LoggerHandler log = LoggerHandler.getInstance();
		log.createLog(this);
	}

}
