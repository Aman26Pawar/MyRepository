package dao;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import Entity.Student;

@Repository
public interface StudentRepository extends JpaRepository<Student, Integer> {

}
