package com.example.demo;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.StoredProcedureQuery;

import com.example.demo.repositoriess.StudentRepositoryCustom;

public class StudentRepositoryImpl implements StudentRepositoryCustom 
{

	@PersistenceContext
	private EntityManager em;

	@Override
	public void getAllStudents() {
		this.em.createNativeQuery("getAllStudents").executeUpdate();
		
	}
	
	/*@Override
	public List<Student> getAllStudents() {
		StoredProcedureQuery findStudent = em.createNamedStoredProcedureQuery("getAllStudents");
		return findStudent.getResultList();
	}*/
	
}
