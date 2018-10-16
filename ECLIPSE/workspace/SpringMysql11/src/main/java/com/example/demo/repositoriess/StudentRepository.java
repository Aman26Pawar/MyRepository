package com.example.demo.repositoriess;

import org.springframework.data.repository.PagingAndSortingRepository;
import com.example.demo.Student;

public interface StudentRepository extends PagingAndSortingRepository<Student, Integer>
{
	
}
