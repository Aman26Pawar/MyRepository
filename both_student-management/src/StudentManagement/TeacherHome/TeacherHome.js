import React from 'react';
import { connect } from 'react-redux'
import Button from "../Buttons/Button.js";
import Home from "./Home";
import AddNewStudent from '../AddUser/AddNewStudent'
import Login from '../Login/LoginPage';
import { Redirect } from 'react-router-dom';
import ListOfStudents from '../ListDisplay/ListOfStudents.js';
//import { Auth } from "aws-amplify";
//import axios from 'axios';

class TeacherHome extends React.Component
{
    constructor(props)
    {
      super(props);
      this.state={
          Teachername:"",
          listOfStudentsCalled:false,
          addNewStudentCalled:false,
          logOutCalled:false,
          referrer:null          
    };
    this.handleListOfStudents=this.handleListOfStudents.bind(this);
    this.handleNewStudent=this.handleNewStudent.bind(this);
    this.handleLogOut=this.handleLogOut.bind(this);    
    }

   

    handleListOfStudents()
    {  
        console.log("ListOfStudents hit....")
        this.props.history.push('/ListOfStudents')
        //this.setState({listOfStudentsCalled:!this.state.listOfStudentsCalled})
    }
    handleNewStudent()
    {
        console.log("Add student hit....")
        this.props.history.push('/AddNewStudent')
        //this.setState({addNewStudentCalled:!this.state.addNewStudentCalled})
    }
    handleLogOut = async event =>
    {
        const logout = this.props.teachers[0]
        this.props.dispatch({
            type:'LOGOUT',
            logout})
        //this.props.history.push('/')
        this.setState({logOutCalled:!this.state.logOutCalled})
    }

    render()
    {
        const {addNewStudentCalled}=this.state;
        if(addNewStudentCalled){
            return <AddNewStudent teacherId={this.props.teachers.teacherID}></AddNewStudent>
        }
        const{referrer}=this.state
        const {listOfStudentsCalled}=this.state;
       
        const {logOutCalled}=this.state;
        if(referrer)
        {
            return <Redirect to={referrer}></Redirect>
        }
        if(listOfStudentsCalled){
            return <ListOfStudents></ListOfStudents>
        }
        
        if(logOutCalled){
            return <Login></Login>
        }
        console.log(this.props.teachers)
        return(
            <div id ="TeacherHome" className="col-75 ">
                <div className="right">  
                    <h2> Teacher:{this.props.teachers.firstName} {this.props.teachers.lastName}</h2>
                </div>
                <div className="center">
                    <Home/>
                </div>   
                <form>
                    <Button handleOnClick={this.handleListOfStudents} buttonName="List Of Students"> </Button>
                    <Button handleOnClick={this.handleNewStudent} buttonName="Add New Students"> </Button>
                    <Button handleOnClick={this.handleLogOut} buttonName="Log Out"> </Button>
                </form>
            </div>
        );
    }
  
}
const mapStateToProps = (state) => {
    return{
        teachers:state.LoginReducer[0]
    }
}
export default connect (mapStateToProps) (TeacherHome);