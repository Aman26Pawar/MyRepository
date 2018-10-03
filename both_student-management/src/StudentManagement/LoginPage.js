import React from 'react';
import axios from 'axios'
import TeacherHome from './TeacherHome';
import '../App.css';
import { Auth } from "aws-amplify";
//import { Cookies } from 'react-cookie'

export default class Login extends React.Component{
    constructor(props)
    {
      super(props);
      this.state={
        validCredentials:false,
        loggedData:[],
        sessionData:[],
        hits:null,
        isAuthenticated: false,
        isAuthenticating: true
      }
      this.onLoginClick=this.onLoginClick.bind(this);
      this.checkLoginCredentials= this.checkLoginCredentials.bind(this)
    }

    async componentDidMount() {
        try {
          if (await Auth.currentSession()) {
            this.userHasAuthenticated(true);
          }
        }
        catch(e) {
          if (e !== 'No current user') {
            alert(e);
          }
        }
        this.setState({ isAuthenticating: false });
      }
    
      userHasAuthenticated = authenticated => {
        this.setState({ isAuthenticated: authenticated });
      }
    

    /*componentDidUpdate(key){
        localStorage.setItem(key,JSON.stringify(this.teacherData.firstName))
        console.log(key)
    }*/
    onLoginClick()
    {
        const uname = document.getElementById("userName").value
        const pw =document.getElementById("password").value
        axios.get("http://localhost:8080/viewTeacher",{mode:"no-cors"})
        .then(res=>res)
        .then(row => {
                this.checkLoginCredentials(row.data,uname,pw)
                     }) 
    }

checkLoginCredentials(fetchedData,uname,pw)
{
    for(let i=0;i<fetchedData.length;i++)
    {
        if(fetchedData[i].userName===uname && fetchedData[i].password===pw)
        {
            this.setState({validCredentials:!this.state.validCredentials})
            this.setState({loggedData:fetchedData[i]})
            break;
        }
    }
}
    onSignUpClick()
    {
        this.props.history.push("/Registration")
    }



    render()
    {
        const childProps = {
            isAuthenticated: this.state.isAuthenticated,
            userHasAuthenticated: this.userHasAuthenticated
          };
        if(this.state.validCredentials === true){
            return <TeacherHome teacherData={this.state.loggedData} props={childProps}/>
        }
        return(
        <div id="LoginData" className="LoginPage">
            <label>User Name:</label>
            <input id="userName" type="text"  placeholder="User Name" ref={node => this.input = node}></input>
            <br/>
            <label>Password:</label>
            <input id="password" type="password" placeholder="New password"></input>
            <br/>
            <button onClick={this.onLoginClick}>Login</button><br/><br/>
            <a href="/"> Home </a><br/><br/>
            <a href="/Registration">Registration</a>      
        </div>
        )
    }
   
}