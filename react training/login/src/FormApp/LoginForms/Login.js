import {Component} from 'react'

class Login extends Component{
    render(){
        return(
            <div>
                <label>
                        User Name:
                        <input type="text" placeholder="User Name"></input>
                    </label>
                    <br/>
                    <label>
                        Password:
                        <input type="password" placeholder="New password"></input>
                    </label>
                    <input type="submit" value="submit">Login</input>
            </div>
        )
    }
}