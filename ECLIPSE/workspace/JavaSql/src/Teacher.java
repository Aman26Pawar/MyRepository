public class Teacher 
{
	public String getTeacher()
	{
		 String selectSql;
	     selectSql = "SELECT TeacherID,firstName,lastName,userName,password FROM TeacherInfo";
	     return selectSql;
	}
	
	public String insertTeacher()
	{
		String insertSql;
		insertSql = "INSERT into (firstName,lastName,userName,password) values(?,?,?,?) ";
		return insertSql;
	}
	
	public void deleteTecherByID(int id)
	{
		String deleteSql;
		deleteSql = "Delete firstName,lastName,userName,password from TeacherInfo where TeacherID = id ";
	}
}
