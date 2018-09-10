package MainPkg;
import org.springframework.context.annotation.Bean;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
/*import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;*/

@RestController
public class TeacherInfo {
	/*@Id
    @GeneratedValue(strategy=GenerationType.AUTO)*/
    private int TeacherID;
	private String firstName;
	private String lastName;
	private String userName;
	private String password;
	public TeacherInfo(String firstName,String lastName,String userName,String pasasword) {
		this.firstName=firstName;
		this.lastName = lastName;
		this.userName=userName;
		this.password=pasasword;
	}
	@RequestMapping("/")
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return String.format("Teacher[id='%d',firsName='%s',lastName='%s',userName='%s',password='%s']", TeacherID,firstName,lastName,userName,password) ;
	}
	 
	    public String index() {
	        return "Greetings from Spring Boot!!!!";
	    }
}
