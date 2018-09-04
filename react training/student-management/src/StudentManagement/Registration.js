import React,{Component} from 'react'

export default class Registration extends Component{
    constructor(props){
        super(props);
        this.state = {
            FirstName:"",
            LastName:"",
            userNm:"",
            passWord:"",
            fields:{},
            errors:{}
        }
    }

    validateFirstName = (First_name) =>{
        //let errors = {};
        let formIsValid = false;
        let msg = "";
       var isRequired = document.getElementById('name').required    
        if(isRequired && First_name !== ""){
            if(First_name.length > 10) {
                msg = "length should not exceed 10 letters";
            }else if(First_name.match(/^[a-zA-Z]+$/)){
                formIsValid = true;
                this.setState({FirstName : First_name});
            }else {
                msg = "Only Letters allowed"
            }
         }
         //let errorMsg = msg;
         var errorElement = document.getElementsByClassName('error');
         if(formIsValid === true) {
            //errorElement.className =errorElement.className.removeClass('hide')
            //document.getElementsByClassName('error').value = msg;
            return formIsValid;
         } else {
            errorElement.className += 'hide';
         }
        
    }
    validateLastName = (Last_name) =>{
        //let errors = {};
        let formIsValid = false;
        let msg = "";
       var isRequired = document.getElementById('lastName').required    
        if(isRequired && Last_name !== ""){
            if(Last_name.length > 10) {
                msg = "length should not exceed 10 letters";
            }else if(Last_name.match(/^[a-zA-Z]+$/)){
                formIsValid = true;
                this.setState({LastName : Last_name});
            }else {
                msg = "Only Letters allowed"
            }
         }
        // let errorMsg = msg;
         //var errorElement = document.getElementsByClassName('error');
         if(formIsValid === true) {
            //errorElement.className =errorElement.className.removeClass('hide')
            //document.getElementsByClassName('error').value = msg;
            return formIsValid;
         } else {
            //errorElement.className += 'hide';
         }
        
    }
    validatePassword = (passWord) =>{
        let formIsValid = false;
        let msg=""
        var isRequired = document.getElementById('pass_word').required 
        if(isRequired && passWord !==""){
            if(passWord.length < 6){
                msg = "password must contain atleast 6 digits"
            }else{
                formIsValid = true
                this.setState({passWord:passWord });
            } 
        }

        if(formIsValid === true){
            return formIsValid
        }else{

        }
    }
    validateUserName = (user_Name) =>{
        let formIsValid = false;
        let msg 
        var isRequired = document.getElementById('user').required 

        if(isRequired && user_Name!==""){
            if(user_Name.match(/^[a-z0-9]+$/)){
                formIsValid = true
                this.setState({userNm:user_Name });
                return formIsValid
            }else{
                msg = "user name should be alphanumeric"
            }
        }
    }
    onSubmitClick = () => {
        //let fields = this.state.fields;
       // let errors = {};
        //let formIsValid = false;
        //let msg = "";
        //let nameField = document.getElementById('name');

         //Name
        const First_name = document.getElementById("name").value;
        const last_name = document.getElementById("lastName").value;
        const userNm = document.getElementById("user").value;
        const passWord = document.getElementById("pass_word").value;
        //this.validateFirstName(First_name);
        if(this.validateFirstName(First_name) && this.validateLastName(last_name) && this.validateUserName(userNm) && this.validatePassword(passWord)){
            alert("valid form")
        }else{
            alert("Form has errors")
        }       
    }
   
    render(){
        return(
            <div className = "RegistrationPage">
                 <form>
                    <div className="name">
                        <label>First Name: </label>
                        <input id="name" type="text" size="15" placeholder="First Name" required/> 
                        <br/>
                        <label>Last Name: </label>
                            <input id="lastName" type="text" size="15" placeholder="last name" required />
                            <br/>
                        <label>Password: </label>
                            <input id="pass_word" type="password" size="15" placeholder="New password" required/>
                            <br/>
                        <label>User Name:</label>
                            <input id="user" type="text" size="15" placeholder="User Name" required/>
                            <br/>
                    </div>
                    <button  value="submit" onClick={this.onSubmitClick}>Submit</button>
                </form>
            </div>
        )
    }
}

/*
<label>First Name: </label>
<input id="name" type="text" size="10" placeholder="First Name" required/> 
 <p className="error hide name" value="Specify Value in this field"></p>
<br/>
<label>Last Name: </label>
<input id="lastName" type="text" size="10" placeholder="last name" required="true" />
<p className="error hide" value="only letters"/>

<label>User Name:</label>
<input id="userName" type="text" size="30" placeholder="User Name" required="true"/>
<br/>
<label>Password  :   </label>
<input id="password" type="password" size="30" placeholder="New password" required="true" onChange={this.handlePassword} />
<br/>
<label>Confirm Password:</label>
<input id="confirmPass" type="password" size="30" placeholder="Re-write password" required="true" />
<br />
*/