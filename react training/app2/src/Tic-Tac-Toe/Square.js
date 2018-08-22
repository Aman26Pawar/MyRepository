import React from 'react';
export default function Square(props)
{   
    /*constructor(props){
        super(props);
        this.state={
            value:null
        };
    }*/

    return(
        <button className="Square" 
            onClick={props.onClick} 
            >
        { props.value}
        </button>
    );

}
