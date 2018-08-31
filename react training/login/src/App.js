import React, { Component } from 'react';
import {BrowserRouter as Router , Link, Route} from 'react-router-dom'

import './App.css'
import Home from '../src/FormApp/Routings/Home.js'
import StartUp from './FormApp/StartUp'
import Login from '../src/FormApp/LoginForms/Login.js'


class App extends Component {
  render() {
    return (
      <div className="App">
      <Router>
       <div>
         <ul>
          <li><Link to = "/">Home</Link></li>
          <li> <Link to = "/StartUp">Start Up</Link></li>
          <li><Link to = "/Login">Login</Link></li>
         </ul>
         <switch>
         <Route exact path='/' component={Home} />
         <Route exact path='/StartUp' component={StartUp} /> 
         <Route exact path ='/Login' component={Login}/>
         </switch>
       </div>
     </Router>
    </div>
     
    );
  }
}

export default App;
