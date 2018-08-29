import React, {Component} from 'react'

import UserSignUp from '../../FormApp/SignUpForms/User/UserSignUp.js'

class SignUpEvents extends Component{
    /*render(){
        return(
            this.HandleSignUp()
        )
    }*/

    handleSignUp(event) {
        this.setState({UserSignUp})
        return
    }
}

export default SignUpEvents