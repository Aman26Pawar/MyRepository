package com.example.demo;

import java.util.List;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

import tables.Teacher;
import templatess.TeacherJDBCTemplate;

@SpringBootApplication
public class StudentProejctApplication {

	public static void main(String[] args) {
		SpringApplication.run(StudentProejctApplication.class, args);
ApplicationContext context = new ClassPathXmlApplicationContext("Beans.xml");
		
		TeacherJDBCTemplate teacherJDBCTemplate = (TeacherJDBCTemplate) context.getBean("TeacherJDBCTemplate");
		
		 System.out.println("------Records Creation--------" );
		 teacherJDBCTemplate.create("Aman", "pawar", "amanp", "aman452");;
	     

	      System.out.println("------Listing Multiple Records--------" );
	      List<Teacher> teachers = teacherJDBCTemplate.listTeacher();
	      for (Teacher record : teachers ) 
	      {
	    	  System.out.print("ID : " + record.getTeacherID());
	          System.out.print(", FirstName : " + record.getFirstName());
	          System.out.println(", Lastname : " + record.getLastName());
	          System.out.println(",User name :" + record.getUserName());
	          System.out.println(",Password : "+ record.getPassword());
	      }

	}
}
