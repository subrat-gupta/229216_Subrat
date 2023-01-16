import axios from "axios";
import {useState} from 'react';


const InsertStudents=()=>{
    const[studarr,setstudarr] = useState({name:"",course:""});

const saveData=(event)=>{
    event.preventDefault();
    axios.post('http://localhost:5096/api/student',studarr);
}

const handleChange=(event)=>{
    const {name,value}=event.target
    setstudarr({...studarr,[name]:value})
}

 return(
    <>
    <h3>Add New User</h3>
    <form method="POST" onSubmit={saveData}>
        <input type="text" name="name" onChange={handleChange} placeholder="Student Name"/>
        <input type="text" name="course" onChange={handleChange} placeholder="Student Course"/>
        <input type="submit"/>
    </form>
    </>
 )
} 
export default InsertStudents;

