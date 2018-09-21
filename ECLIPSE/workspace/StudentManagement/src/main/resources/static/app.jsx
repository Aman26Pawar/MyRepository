var React = require('react')
var client = require('./client')

var App = React.createClass({
	getInitialState: function(){
	return ({teachers:[]});
	},
	componentDitMount: function(){
	client({method:'GET',path:'/teachers'}).done(response=>{
			this.setState({teachers:response.entity._embedded.teachers});
			});
		},
		render:function(){
			return(
				<TeacherList teachers={this.state.teachers}/>
				)
			}
		})		
		
		
var TeacherList = React.createClass({
   			 render: function () {
        var teachers = this.props.teachers.map(teacher =>
            <Teacher key={teacher._links.self.href} data={teacher}/>
        );
        return (
            <table>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>User Name</th>
                    <th>password</th>
                </tr>
                {teachers}
            </table>
        )
    }
})	
			
			
			
var Teacher = React.createClass({
	render:function(){
		 return (
            <tr>
                <td>{this.props.teacher.firstName}</td>
                <td>{this.props.teacher.lastName}</td>
                <td>{this.props.teacher.userName}</td>
                <td>{this.props.teacher.password}</td>
            </tr>
        )
	}
})
			
			
React.render(
	<App/>,
	document.getElementById('react')
)