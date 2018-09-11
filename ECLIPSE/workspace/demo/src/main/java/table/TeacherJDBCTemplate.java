package table;

import java.util.List;

import javax.sql.DataSource;

import org.springframework.jdbc.core.JdbcTemplate;

import repositories.TeacherDAO;

public class TeacherJDBCTemplate implements TeacherDAO
{
	private DataSource dataSource;
	private JdbcTemplate jdbcTemplateObject;

	@Override
	public void setDataSource(DataSource ds) {
		 this.dataSource = dataSource;
	     this.jdbcTemplateObject = new JdbcTemplate(dataSource);
		
	}

	@Override
	public void create(String firstName, String lastName, String userName, String password) {
		String insertSql = "insert into TeacherInfo(firstName,lastName,userName,password) values (?,?,?,?)";
		jdbcTemplateObject.update(insertSql,firstName,lastName,userName,password);
		System.out.println("Created record...");
		return;
	}

	@Override
	public Teacher getTeacher(int id) {
		String selectSql = "select (TeacherID,firstName,lastName,userName,password) from TeacherInfo where id=?";
		Teacher teacher =jdbcTemplateObject.queryForObject(selectSql, new Object[]{id}, new TeacherMapper());
		return teacher;
	}

	@Override
	public void deleteTeacher(int id) {
		String deleteSql = "delete from TeacherInfo where id =?";
		jdbcTemplateObject.update(deleteSql, id);
	    System.out.println("Deleted Record with ID = " + id );
	    return;
	}

	@Override
	public void updateTeacher(int id, String firstName, String lastName, String userName, String password) {
		String updateSql = "update Student set firstName=?,lastName=?,userName=?,password=? where id = ?";
	      jdbcTemplateObject.update(updateSql, firstName,lastName,userName,password);
	      System.out.println("Updated Record with ID = " + id );
	      return;
		
	}

	@Override
	public List<Teacher> listTeacher() {
		 String SQL = "select (TeacherID,firstName,lastName,userName,password) from TeacherInfo";
	      List <Teacher> teachers = jdbcTemplateObject.query(SQL, new TeacherMapper());
	      return teachers;
	}

}
