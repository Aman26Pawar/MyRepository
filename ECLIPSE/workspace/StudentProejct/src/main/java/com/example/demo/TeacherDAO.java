package com.example.demo;

import java.util.List;

import javax.sql.DataSource;



public interface TeacherDAO {

	 public void setDataSource(DataSource ds);
	 public void create(String firstName,String lastName,String userName,String password);
	 public Teacher getTeacher(int id);
	 public void deleteTeacher(int id);
	 public void updateTeacher(int id,String firstName,String lastName,String userName,String password);
	 public List<Teacher> listTeacher();
}
