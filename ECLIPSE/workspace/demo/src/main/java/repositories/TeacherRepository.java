package repositories;

import org.springframework.data.repository.CrudRepository;

import table.Teacher;

public interface TeacherRepository extends CrudRepository<Teacher, Long> {

}
