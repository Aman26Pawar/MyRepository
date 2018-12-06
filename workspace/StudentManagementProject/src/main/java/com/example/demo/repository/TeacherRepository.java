package com.example.demo.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import com.example.demo.entity.Teacher;



public interface TeacherRepository extends JpaRepository<Teacher, Integer>
{
	String TEACHER_AUTHENTICATION = "SELECT TeacherID ,FirstName, LastName, UserName, Password FROM teacherinfo WHERE UserName = :userName AND Password = :password";
	@Query(value = TEACHER_AUTHENTICATION, nativeQuery=true)
	Teacher login(@Param("userName") String userName, @Param("password") String password);
}
