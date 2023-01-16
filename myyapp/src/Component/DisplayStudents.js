import { useEffect,useState } from "react";
import axios from 'axios';

const DisplayStudents =()=>{
  const[studarr,setstudarr]=useState([]);
  useEffect(
    ()=>{
        axios.get("http://localhost:5096/api/student")
        .then(response =>{setstudarr(response.data)});
    }
  )

  var renderList = studarr.map(stud=>{
    return(
        <tr>
            <td>{stud.id}</td>
            <td>{stud.name}</td>
            <td>{stud.course}</td>
        </tr>
    )
  });

    return (
        <>
        <table id="table" border="2" bgcolor="skyblue">
            <tr>
                <td>Student ID</td>
                <td>Student Name</td>
                <td>Student Course</td>
            </tr>
            {renderList}
        </table>
        </>
    )
}

export default DisplayStudents;