import React from 'react';
import EditLink from './EditLink';
import './Button.css'
import Button from './Button';

import axios from 'axios'

class ListOfStudents extends React.Component
{
    constructor(props)
    {
        super(props)
        this.handleBack=this.handleBack.bind(this);
        this.state={
            students:[],
        }
    }
    handleBack()
    {
        this.props.history.push('/TeacherHome');
    }


    componentDidMount(){
        this.loadStudentsFromServer()
    }

    loadStudentsFromServer(){

      fetch('http://localhost:8080/getAllStudent')
        .then(res => res.json())
        .then((rows=[]) => {
          this.setState({ students: rows })
          console.log(this.state.students)
        })

       /*let studentsList=[];
        axios.get('http://localhost:8080/getAllStudent') 
        .then(function (response) {
            studentsList=response.data
            console.log(studentsList)
            response.data.forEach(element => {
                console.log(element);
            });
        });   */    
    }

   

    render()
    {
        return( 
            <div>
                 <table className="center">
                    {   <tr>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>TeacherID</th>
                            <th>class</th>
                            <th>division</th>
                            <th>line1</th>
                            <th>line2</th>
                            <th>pinCode</th>
                        </tr>
                    }
                     </table> 
        <table className="center">
        {
                         this.state.students.map((students,i)=>{
                         return (
                             <tr>
                             <td>{students.firstName}</td>
                             <td>{students.lastName}</td>
                             <td>{students.TeacherID}</td>
                             <td>{students.classs}</td>
                             <td>{students.division}</td>
                             <td>{students.line1}</td>
                             <td>{students.line2}</td>
                             <td>{students.pinCode}</td>
                             </tr>
                                ) 
                                            })    
         }
        </table>        
                <EditLink></EditLink>
                <Button buttonName="Back" handleOnClick={this.handleBack}/>
            </div>
        );
    }
}
export default ListOfStudents;  























    // constructor(props)
    // {
    //     super(props);
    //     this.handleList = this.handleList.bind(this);
    // }
    // handleList()
    // {
    //     var names = [['1','Venu','v c', '9','D','MP,Null stop','pune','780405'],
    //                 ['2','Veag','Kta', '9','A','hp,Swargate','pune','780404'],
    //                 ['3','ragha','Sha', '9','B','LK,Karve road','pune','780801']];
    //     return (
    //         <div >
                
    //         <table>
    //         {
                
    //             names.map(function(name, index) 
    //             {
    //                 return <div> 
    //                         <tr>
    //                             <td>{name[0]}</td>
    //                             <td>{name[1]}</td>
    //                             <td>{name[2]}</td>
    //                             <td>{name[3]}</td>
    //                             <td>{name[4]}</td>
    //                             <td>{name[5]}</td>
    //                             <td>{name[6]}</td>
    //                             <td>{name[7]}</td>
    //                             <td><EditLink></EditLink></td>
    //                             <td><DeleteLink></DeleteLink></td>
    //                         </tr>
    //                       </div>
    //             })
    //         }
    //         </table>
    //     </div>
    //     )
    // }
    // render() {
    // return (
    //         <div>
    //             <center> {this.handleList()} </center>
    //         </div>
    //         );
    //         }


