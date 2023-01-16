import { useState } from "react";
import axios from 'axios';

const Delete = () => {
    const [studarr, setstudarr] = useState({id:""});
    
    const deleteStd = (event) => {
        event.preventDefault();
        axios.delete(`http://localhost:5096/api/student/${studarr.id}`);
    }

    const handleChange=(event)=>{
        const {name,value} =event.target
        setstudarr({...studarr,[name]:value})
    }

    return (
        <>
            <br/><br/>
            <h4>Enter student's rollno to be deleted.</h4>
            <form method="GET" onSubmit={deleteStd}>
                <input type="text" name="id" onChange={handleChange} placeholder="UserId"/>
                <input type="Submit" value="Delete"/>
            </form>
        </>
    );

}
export default Delete;