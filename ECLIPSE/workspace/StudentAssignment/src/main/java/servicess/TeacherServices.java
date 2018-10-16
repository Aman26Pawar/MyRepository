package servicess;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;

import Entity.Teacher;
import dao.TeacherRepository;

@Service
public class TeacherServices
{
	@Autowired
	private TeacherRepository teacherRepository;
	
	public Teacher addTeacher(@RequestBody Teacher teacher, @PathVariable int id){
		
		return teacher;
		
	}
}
