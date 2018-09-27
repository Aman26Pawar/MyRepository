import React from 'react';
import axios from 'axios'
import TeacherHome from './TeacherHome';
//import { Cookies } from 'react-cookie'

export default class Login extends React.Component{
    constructor(props)
    {
      super(props);
      this.state={
          validCredentials:false,
          loggedData:[]
      }
      this.onLoginClick=this.onLoginClick.bind(this);
      this.checkLoginCredentials= this.checkLoginCredentials.bind(this)
    }
   

    onLoginClick()
    {
        const uname = document.getElementById("userName").value
        const pw =document.getElementById("password").value
        axios.get("http://localhost:8080/viewTeacher")
        .then(res=>res)
        .then(row => {
                this.checkLoginCredentials(row.data,uname,pw)
                     }) 
    }

    checkLoginCredentials(fetchedData,uname,pw){
        for(let i=0;i<fetchedData.length;i++)
        {
            console.log(fetchedData[1].userName)
            if(uname===fetchedData[i].userName && pw===fetchedData[i].password)
            {
                this.setState({validCredentials:!this.state.validCredentials})
                this.setState({loggedData:fetchedData[i]})
                console.log(this.state.loggedData)
                console.log("success")
                this.props.history.push("/TeacherHome")
                return <TeacherHome teacherData="{this.state.loggedData}"/>
            }
           /* else{
                alert("Please enter correct credentials")
                break
            }*/
            return this.state.validCredentials
        }
    }
    onSignUpClick()
    {
        this.props.history.push("/Registration")
    }



    render()
    {
        /*if(this.state.validCredentials === true){
            return <TeacherHome teacherData={this.state.loggedData}/>
        }*/
        return(
        <div className="LoginPage">
            <label>User Name:</label>
            <input id="userName" type="text"  placeholder="User Name"></input>
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