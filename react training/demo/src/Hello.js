import React from 'react' 
export default class HelloComponent extends React.Component
{
    constructor(props){
        super(props);
        this.state={value:'sohil111'}
    }
    componentWillMount(){
        this.setState({'value':'sohil'});
    }
    componentDidMount(event){
        //alert('setting value late');
        document.getElementById('textBox').value = this.state.value;
    }
    render(){
        var welcome = this.Welcome();
        return <div>{welcome}</div>
    }
Welcome() {
       /* let name ="aman"
        return(alert(<h1>'Hello'+ {name}</h1>)) */
            return(
                    <form onSubmit={this.addData}>
                        <label>
                         Name:
                         </label>
                        <input id="textBox" type="text"></input>
                        <input type="Submit" value="Enter"></input>
                    </form>
                 );
    }
    addData(event){
        (alert('Hello, '+ this.state.value))
        
    }
}
