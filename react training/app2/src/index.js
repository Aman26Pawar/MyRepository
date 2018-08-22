import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import Boards from './Tic-Tac-Toe/Boards'
import registerServiceWorker from './registerServiceWorker';

//ReactDOM.render(<App />, document.getElementById('root'));
ReactDOM.render(<Boards/>, document.getElementById('root'));
registerServiceWorker();

