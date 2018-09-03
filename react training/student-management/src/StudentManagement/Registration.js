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
    onSubmitClick = () => {
        //let fields = this.state.fields;
        let errors = {};
        let formIsValid = false;
        let msg = "";
        //let nameField = document.getElementById('name');


        //Name
        /*if(!fields["name"]){
           formIsValid = false;
           errors["name"] = "Cannot be empty";
        }*/
        //this.validateBaiscChecks(nameField);
       var isRequired = document.getElementById('name').getAttribute('required') === "true";

        const First_name = document.getElementById("name").value;
        if(isRequired && First_name !== ""){
            if(First_name.size() > 30) {
                msg = "Only Letters allowed";
            }
            else if(First_name.match(/^[a-zA-Z]+$/)){
                formIsValid = true;
                this.setState({FirstName : First_name});
            } else {
                msg = "Only Letters allowed"
            }
         }

         var errorElement = document.getElementsByClassName('.error.name');
         if(!formIsValid) {
            errorElement.removeClass('hide');
            document.getElementsByClassName('.error.name').value = msg;
            //find how to add remove classes in javascript.
            // addClass., removeClass.
         } else {
            errorElement.className += 'hide';
         }

        const last_name = document.getElementById("lastName").value;
        if(last_name !== ""){
            if(last_name.match(/^[a-zA-Z]+$/)){
                this.setState({LastName : last_name})
            }  
            else{
                formIsValid = false;
               // errors[last_name] = "Only letters";
               
            }
         }
       
        const userNm = document.getElementById("userName").value;
        this.setState({userNm:userNm });
        const passWord = document.getElementById("password").value;
        if(passWord.size < 6){
            errors[passWord] = "password must be at least 6 digits";
            alert(passWord.size())
        }
       
        this.setState({passWord:passWord });
        alert(`${this.state.FirstName} ${last_name}, registered succesfully`)

        this.setState({errors: errors});
        return formIsValid;
        
        /*if(First_name ==="" || last_name==="" || userNm===""||passWord===""){
            alert("please fill all he information")
        }
        else{
            alert(`${First_name} ${last_name}, registered succesfully`)
        }*/

    }
    handlePassword(){

    }
   /* contactSubmit(e){
        alert("submit")
    }
    handleChange(field,e){
        let fields = this.state.fields;
        fields[field] = e.target.value;        
        this.setState({fields});
    }*/
    render(){
        return(
            <div className = "RegistrationPage">
                 <form>
                    <div className="name">
                        <label>First Name: </label>
                        <input id="name" type="text" size="30" placeholder="First Name" required="true" />
                        <p className="error hide name" value="Specify Value in this field"></p>
                        <br/>
                    </div>
                    <button  value="submit" onClick={this.onSubmitClick}>Submit</button>
                </form>
            </div>
        )
    }
}

/*
<label>Last Name: </label>
<input id="lastName" type="text" size="30" placeholder="last name" required="true" />
<p className="error hide" value="only letters"/>
<br/>
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