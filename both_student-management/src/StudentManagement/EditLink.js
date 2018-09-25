import React from 'react';
import Button from './Button'

class EditLink extends React.Component
{
    handleDelete() {
		this.props.onDelete(this.props.students);
	}
    render()
    {
        return(
                <div>
                        <a href="/ListOfStudents/EditStudent"> Edit </a><br/> <br/>
                        <a href="/ListOfStudents/DeleteStudent">Delete</a>
                       
                       
                </div>
        );
    }
}
export default EditLink;