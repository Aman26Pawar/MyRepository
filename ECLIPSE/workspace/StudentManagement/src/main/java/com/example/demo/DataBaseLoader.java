package com.example.demo;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import com.example.demo.repositoriess.TeacherRepository;

@Component
public class DataBaseLoader implements CommandLineRunner
{
	private final TeacherRepository teacherRepository;
	
	@Autowired
	public DataBaseLoader(TeacherRepository teacherRepository) 
	{
		this.teacherRepository=teacherRepository;
	}

	@Override
	public void run(String... args) throws Exception {
		this.teacherRepository.save(new Teacher("J.J.","Pawar","jp","45gfs78"));
	}
	
}
