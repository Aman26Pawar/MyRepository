package com.example.demo.DAO;

import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import com.example.demo.entity.Teacher;
import com.example.demo.exceptionHandling.ResourceNotFoundException;
import com.example.demo.repository.TeacherRepository;

public class TeacherDAO 
{
	@Autowired
	private TeacherRepository teacherRepository;
	
	 public ResponseEntity<?> createTeacher(@RequestBody Teacher teacher) {
		 System.out.println("New Teacher Added....");
		 teacherRepository.save(teacher);
		 return ResponseEntity.ok().build();     
	 }
	 
	public List<Teacher> getAllTeachers()
	{
		System.out.println("Get All Teachers.......");
		return teacherRepository.findAll();
	}
		
	public Teacher  loginTeacher(@RequestBody Teacher teacherLogin){
		 String loggedUser = teacherLogin.getUserName();
		 String loggedPassword = teacherLogin.getPassword();
		 System.out.println(teacherRepository.login(loggedUser, loggedPassword));
		 return teacherRepository.login(loggedUser, loggedPassword);
		
	}
	
	 public Teacher getTeacherById(@PathVariable(value = "id") Integer teacherId) {
		 System.out.println("getTeacheryID");
	     return teacherRepository.findById(teacherId)
	           .orElseThrow(() -> new ResourceNotFoundException("Teacher", "id", teacherId));
	 }
	
	 public Teacher updateTeacher(@PathVariable(value = "id") Integer teacherId,
	                           @Valid @RequestBody Teacher teacherDetails) {
		 System.out.println("teacher updated.........");
	      Teacher teacher = teacherRepository.findById(teacherId)
	         .orElseThrow(() -> new ResourceNotFoundException("Teacher", "id", teacherId));
	        teacher.setFirstName(teacherDetails.getFirstName());
	        teacher.setLastName(teacherDetails.getLastName());
	        teacher.setUserName(teacherDetails.getUserName());
	        teacher.setPassword(teacherDetails.getPassword());
	        return teacherRepository.save(teacher);
	 }
	 
	
	 public ResponseEntity<?> deleteTeacher(@PathVariable(value = "id") Integer teacherId) {
		 System.out.println("teacher deleted...");
	    Teacher teacher = teacherRepository.findById(teacherId)
	            .orElseThrow(() -> new ResourceNotFoundException("Teacher", "id", teacherId));
	      teacherRepository.delete(teacher);
	      return ResponseEntity.ok().build();
	 }
	 

}
