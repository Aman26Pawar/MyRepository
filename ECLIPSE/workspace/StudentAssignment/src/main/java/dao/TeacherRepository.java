package dao;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import Entity.Teacher;

@Repository
public interface TeacherRepository extends JpaRepository<Teacher, Integer> {

}
