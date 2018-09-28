package springbootauthupdated;

import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import com.example.demo.Teacher;
import com.example.demo.repositoriess.TeacherRepository;

import static java.util.Collections.emptyList;

@Service
public class UserDetailsServiceImpl implements UserDetailsService {
    private TeacherRepository teacherRepository;

    public UserDetailsServiceImpl(TeacherRepository applicationUserRepository) {
        this.teacherRepository = applicationUserRepository;
    }

    @Override
    public UserDetails loadUserByUsername(String userName) throws UsernameNotFoundException {
        Teacher teacher = teacherRepository.findByUsername(userName);
        if (teacher == null) {
            throw new UsernameNotFoundException(userName);
        }
        return new User(teacher.getUserName(), teacher.getPassword(), emptyList());
    }
}