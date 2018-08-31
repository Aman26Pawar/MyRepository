import React,{Component} from 'react'
import './UserSignUp.css'

class UserSignUp extends Component {
    constructor(props){
        super(props);
        this.state={
            Name:"",
            email:""
        };
    }
   
   validateName(){
       const name = document.getElementById("name")
        this.setState({Name:name});
        if(name === ""){
            alert("Name should not be empty..")
        }
   }
   validateEmail(){
    const email = document.getElementById("email")
     this.setState({email:email});
     if(email === ""){
         alert("Name should not be empty..")
     }
}
    render(){
        return(
            <div className="UserSignUpForm">
                <form>
                    <label> Name: </label>
                    <input id="name" type="text"  placeholder="First Name" />
                    <br/>
                    <label> Email: </label>
                    <input id="email" type="text" placeholder="Email"  />
                    <br/>
                    <label> User Name: </label>
                    <input id="userName" type="text" placeholder="User Name" />
                    <br/>
                    <label>Password:</label>
                    <input id="password" type="password" placeholder="New password" />
                    <br/>
                    <label>Confirm Password:  </label>
                    <input id="confirmPass" type="password" placeholder="Re-write password"  />
                    <br />
                    <button  value="submit" onClick={this.props.onSubmitClick}>Submit</button>
                </form>
            </div>
        );
    }
}
export default UserSignUp