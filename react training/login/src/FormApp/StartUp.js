import React,{Component} from 'react'

import UserSignUp from './SignUpForms/User/UserSignUp.js'
import Button from './Components/Button.js'
import Login from './LoginForms/Login.js'

class StartUp extends Component{

    constructor(props){
        super(props);
        this.state = {
            userSignUpBool: false,
            userSignInBool: false,
            userFirstName: "",
            userEmail:"",
            userNm:"",
            passWord:"",
            loggedUser: "",
            nameError:false
        };
    }

    handleRegistration = () => {
        this.setState({userSignUpBool : !this.state.userSignUpBool});
    }

    handleLogin = () => {
        this.setState({userSignInBool : !this.state.userSignInBool});
    }
   
  
    onSubmitClick = (e) => {
        const userName = document.getElementById("name").value;
        this.setState({userFirstName:userName });
        const userEmail = document.getElementById("email").value;
        this.setState({userEmail:userEmail });
        const userNm = document.getElementById("userName").value;
        this.setState({userNm:userNm });
        const passWord = document.getElementById("password").value;
        this.setState({passWord:passWord });
        if(userName==="" || userEmail==="" || userNm===""||passWord===""){
            alert("please fill all he information")
        }
        else{
            alert(`Congratulations ${userName}!!!, you have successfully registered `)
        }
        
    }

    /*componentDidUpdate = () => {
                alert(this.state.userFirstName + ' has Registered successfully');
            } */

    onLoginClick = () => {
        const userName = document.getElementById("userName").value;
        this.setState({loggedUser : userName})
        const passwd = document.getElementById("password").value;
        this.setState({passWord:passwd})
        alert(`Welcome ${userName}`);
    }
   /* componentDidUpdate = () => {
        alert(this.state.loggedUser + '... loggedin successfully');
    } */

    
    render(){
        const registrationForm =[]
        const loginForm = []
        
        const signUpButton = <Button onButtonClick={this.handleRegistration} buttonText="Sign Up"></Button>;
        const signInButton = <Button onButtonClick={this.handleLogin} buttonText="Sign In"></Button>;
       
        registrationForm.push(<UserSignUp onSubmitClick={(e) => this.onSubmitClick(e)}></UserSignUp>)
        registrationForm.push(signUpButton)
        //registrationForm.push(signInButton)
        const userSignupBlock = this.state.userSignUpBool ? registrationForm : [signUpButton, signInButton] ;
        
        loginForm.push(<Login onSubmitClick={this.onLoginClick}></Login> )
        const userLoginBlock = this.state.userSignInBool ? loginForm : '';
        return(
            <div className="StartUp">
                {userSignupBlock}
                {userLoginBlock}
            </div>

      

        )
    }

}
export default StartUp