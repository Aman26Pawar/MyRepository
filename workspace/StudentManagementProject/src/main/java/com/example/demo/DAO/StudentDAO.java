package com.example.demo.DAO;

import java.util.List;

import javax.validation.Valid;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.ResponseBody;

import com.example.demo.entity.Student;
import com.example.demo.exceptionHandling.ResourceNotFoundException;
import com.example.demo.repository.StudentRepository;

public class StudentDAO
{

	@Autowired
	private StudentRepository studentRepository;
	
	 public ResponseEntity<?>  createStudent(@Valid @RequestBody Student addStudent) {
		 //System.out.println(addStudent.getFirstName());
		 System.out.println("New student added...");
		 	studentRepository.save(addStudent);
		 	return ResponseEntity.ok().build();
	 }
	 
	
	    public List<Student> getAllStudents() 
		{
		 	System.out.println("get All Students.......");
	        return studentRepository.findAll();
	    }
		

	 
	 public Student getStudentById(@PathVariable(value = "id") Integer studentId) {
	     return studentRepository.findById(studentId)
	           .orElseThrow(() -> new ResourceNotFoundException("Student", "id", studentId));
	 }

	
	 public List<Student> getStudentByTeacherId(@PathVariable(value = "teacher_id") Integer teacher_Id) {
		 System.out.println("get student by teacher id...");
	      return studentRepository.findStudentByTeacherId(teacher_Id);
	 }

	 
	 public ResponseEntity<?> updateStudent(@PathVariable(value = "id") Integer studentId,
	                           @Valid @RequestBody Student studentDetails) {
		 System.out.println("student upated..........");
	      Student student = studentRepository.findById(studentId)
	         .orElseThrow(() -> new ResourceNotFoundException("Student", "id", studentId));
	        student.setFirstName(studentDetails.getFirstName());
	        student.setLastName(studentDetails.getLastName());
	        student.setAddressLine1(studentDetails.getAddressLine1());
	        student.setAddressLine2(studentDetails.getAddressLine2());
	        student.setStudentClass(studentDetails.getStudentClass());
	        student.setDivision(studentDetails.getDivision());
	        student.setTeacherId(studentDetails.getTeacherId());
	        student.setPincode(studentDetails.getPincode());
	        studentRepository.save(student);
	        return ResponseEntity.ok().build();
	 }

	 
	 public ResponseEntity<?> deleteStudent(@PathVariable(value = "id") Integer studentId) {
		 System.out.println("student deleted.............");
	    Student student = studentRepository.findById(studentId)
	            .orElseThrow(() -> new ResourceNotFoundException("Student", "id", studentId));
	      studentRepository.delete(student);
	      return ResponseEntity.ok().build();
	 }
}
