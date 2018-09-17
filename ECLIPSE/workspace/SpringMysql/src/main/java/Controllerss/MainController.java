package Controllerss;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.example.demo.Teacher;

import repositoriess.TeacherRepository;

@RestController
@RequestMapping(path="/demo")
public class MainController 
{
	@Autowired
	private TeacherRepository teacherRepository;
	
	@GetMapping(path="/add")
	@ResponseBody
	public String addNewTeacher(@RequestParam String firstName, @RequestParam String lastName, @RequestParam String userName, @RequestParam String password)
	{
		Teacher addTeacher = new Teacher();
		addTeacher.setFirstName(firstName);
		addTeacher.setLastName(lastName);
		addTeacher.setUserName(userName);
		addTeacher.setPassword(password);
		
		return "Saved";
		
	}
	@GetMapping(path="/view")
	@ResponseBody
	public  Iterable<Teacher> getAllTeachers() {
		return teacherRepository.findAll();
	}
}
