package repositories;

import java.util.List;

import javax.sql.DataSource;

import table.Teacher;

public interface TeacherDAO {

	 public void setDataSource(DataSource ds);
	 public void create(String firstName,String lastName,String userName,String password);
	 public Teacher getTeacher(int id);
	 public void deleteTeacher(int id);
	 public void updateTeacher(int id,String firstName,String lastName,String userName,String password);
	 public List<Teacher> listTeacher();
}
