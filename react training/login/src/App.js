import React, { Component } from 'react';

import StartUp from './FormApp/StartUp'
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
      <header className="App-header">
        <h1 className="App-title">Welcome</h1>
      </header>
      <StartUp></StartUp>
    </div>
     
    //<UserSignUp></UserSignUp>
    );
  }
}

export default App;
