package dao;

import org.springframework.data.repository.PagingAndSortingRepository;

import Entity.Teacher;

public interface TeacherRepository extends PagingAndSortingRepository<Teacher, Integer>
{
	//Teacher findByUsername(String userName);
}
