import React from 'react';
class TeacherHome extends React.Component
{
    render()
    {
        return(
                <div>
                    <h2> Teacher name: </h2>
                    <button type="button" onClick={this.handleLogIn}>List Of Students</button><br/>
                    <button type="button" onClick={this.handleLogIn}>Add New Students</button>
                </div>
        );
    }
}
export default TeacherHome;