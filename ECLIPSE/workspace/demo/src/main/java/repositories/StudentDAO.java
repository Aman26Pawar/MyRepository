package repositories;

import java.util.List;

import javax.sql.DataSource;

import table.Student;

public interface StudentDAO 
{
	public void setDataSource(DataSource ds);
	public void createStudent();
	public void deleteStudent(int id);
	public void updateStudent(int id);
	public List<Student> listOfStudents();
	public void getStudentByID(int id);
	
}
