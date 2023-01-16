using Microsoft.AspNetCore.Mvc;
using DAL;
using Model;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
   

    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [EnableCors()]
    public IEnumerable<Student> GetAllStudents()
    {
        List<Student> students = StudentData.GetAllStudents();
        return students;
      
    }

    [HttpPost]
    [EnableCors()]

    public IActionResult InsertNewStudent(Student student)
    {
        StudentData.InsertStudent(student);
        return Ok(new{message ="student created"});
    }
     

    [Route("{id}")]
    [HttpDelete]
    [EnableCors()]
    public ActionResult<Student> DeleteStudent(int id)
    {
        StudentData.DeleteStudentById(id);
        return Ok(new {message ="User Deleted"});
    }
}
