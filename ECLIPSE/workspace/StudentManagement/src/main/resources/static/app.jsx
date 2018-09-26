var React = require('react')
var client = require('./client')
var root = '/'

class App extends React.Component {

	constructor(props) {
		super(props);
		this.state = {teachers: []};
	}

	componentDidMount() {
		this.loadFromServer(this.state.pageSize);
	}

	render() {
		return (
			<TeacherList teachers={this.state.teachers}/>
		
	}
}		


 loadFromServer(pageSize) {
	follow(client, root, [
		{rel: 'teachers', params: {size: pageSize}}]
	).then(teacherCollection => {
		return client({
			method: 'GET',
			path: teacherCollection.entity._links.profile.href,
			headers: {'Accept': 'application/schema+json'}
		}).then(schema => {
			this.schema = schema.entity;
			return teacherCollection;
		});
	}).done(teacherCollection => {
		this.setState({
			teachers: teacherCollection.entity._embedded.teachers,
			attributes: Object.keys(this.schema.properties),
			pageSize: pageSize,
			links: teacherCollection.entity._links});
	});
}	


class TeacherList extends React.Componet
{
 render() {
        const teachers = this.props.teachers.map(teacher =>
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
		
}	
	
			
			
class Teacher extends React.Component
{
	render(){
		 return (
            <tr>
                <td>{this.props.teacher.firstName}</td>
                <td>{this.props.teacher.lastName}</td>
                <td>{this.props.teacher.userName}</td>
                <td>{this.props.teacher.password}</td>
            </tr>
        )
	}
}





			
			
React.render(
	<App/>,
	document.getElementById('react')
)