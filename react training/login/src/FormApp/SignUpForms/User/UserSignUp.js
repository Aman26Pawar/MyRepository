import React,{Component} from 'react';

import './UserSignUp.css'

class UserSignUp extends Component {
    render(){
        return(
            <div className="UserSignUpForm">
                <form action="" method="GET">
                    <label> First Name: </label>
                    <input type="text" placeholder="First Name" />
                    <br/>
                    <label>
                        Last Name:
                        <input type="text" placeholder="Last Name" />
                    </label>
                    <br/>
                    <label>
                        User Name:
                        <input type="text" placeholder="User Name" />
                    </label>
                    <br/>
                    <label>
                        Password:
                        <input type="password" placeholder="New password" />
                    </label>
                    <br/>
                    <label for="pass">
                        Confirm Password:
                    </label>
                    <input id="pass" type="password" placeholder="Re-write password" />
                    <br />
                    <button value="submit" onClick={this.props.onSubmitClick}>Submit</button>
                </form>
            </div>
        );
    }
}
export default UserSignUp