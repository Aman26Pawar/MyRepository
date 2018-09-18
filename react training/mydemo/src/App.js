import React, { Component } from 'react';
import ReactMySql from './ReactMySql/ReactMySql.js'
import './App.css';

class App extends Component {
  render() {
    return (
      <div className="App">
       <ReactMySql></ReactMySql>
      </div>
    );
  }
}

export default App;
