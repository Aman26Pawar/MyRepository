import React from 'react';

import './Tic-Tac.css'
import Square from './Square.js'
import calculateWinner from './winner'

class Boards extends React.Component
{
    constructor(props){
        super(props);
        this.state={
            squares: Array(9).fill(null),
            xIsNext:true
        };
    }

    handleClick(i){
        const squaresSlice = this.state.squares.slice();
        if(calculateWinner(squaresSlice) || squaresSlice[i]){
            return;
        }
        squaresSlice[i] = (this.state.xIsNext ? 'X':'O');
        this.setState({
            squares:squaresSlice,
            xIsNext:!this.state.xIsNext 
        });
    }
  renderSqaure(i){
    return(
            <Square value={this.state.squares[i]}
            onClick={()=>this.handleClick(i)}
            />
        )
  }
  render(){
      const winner = calculateWinner(this.state.squares)
      let status;
      if(winner){
          status = alert("WINNER is " + winner);
      }
      else{
        status = "Next player "+ (this.state.xIsNext ? 'X' : 'O');
      }
    return(
      <div>
        <div className="status">{status}</div>
        <div className="boardRow">
              {this.renderSqaure(0)}
              {this.renderSqaure(1)}
              {this.renderSqaure(2)}
        </div>
        <div className="boardRow"> 
              {this.renderSqaure(3)}
              {this.renderSqaure(4)}
              {this.renderSqaure(5)}
        </div>
        <div className="boardRow"> 
              {this.renderSqaure(6)}
              {this.renderSqaure(7)}
              {this.renderSqaure(8)}
        </div>
      </div>
    )
  }
}
export default Boards;