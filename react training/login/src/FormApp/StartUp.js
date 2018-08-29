import React,{Component} from 'react'

import UserSignUp from './SignUpForms/User/UserSignUp.js'
import Button from './Components/Button.js'

class StartUp extends Component{

    constructor(props){
        super(props);
        this.state = {
            userSignUpBool: false,
            username: "",
            email: "",
            
        };

    }

    handleRegistration = () => {
        this.setState({userSignUpBool : !this.state.userSignUpBool});
    }

    handleLogin = () => {
        this.setState({userSignUpBool : !this.state.userSignUpBool});
    }

    onSubmitClick = () => {
        alert('submit');
    }

    render(){
        const registrationForm =[]
        const signUpButton = <Button onButtonClick={this.handleRegistration} buttonText="Sign Up"></Button>;
        const signInButton = <Button onButtonClick={this.handleLogin} buttonText="Sign In"></Button>;
        registrationForm.push(<UserSignUp onSubmitClick={this.onSubmitClick}></UserSignUp>)
        registrationForm.push(signUpButton)
        const userSignupBlock = this.state.userSignUpBool ? registrationForm : [signUpButton, signInButton] ;
        return(
            <div className="StartUp">
                {userSignupBlock}
            </div>
        )
    }

}
export default StartUp