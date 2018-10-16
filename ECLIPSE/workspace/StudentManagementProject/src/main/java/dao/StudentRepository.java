package dao;

import org.springframework.data.jpa.repository.query.Procedure;
import org.springframework.data.repository.CrudRepository;

import Entity.Student;

public interface StudentRepository extends CrudRepository<Student, Integer>
{
	@Procedure(name="sp_GetStudent")
	Iterable<Student> getAllStudents();
}
