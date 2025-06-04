using Microsoft.AspNetCore.Mvc;
using StudentManagerAPI.Models;
using StudentManagerAPI.Data;

namespace StudentManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentDataAccess _dataAccess;

        public StudentController(StudentDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public IActionResult GetStudents() => Ok(_dataAccess.GetAll());

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _dataAccess.Add(student);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _dataAccess.Delete(id);
            return Ok();
        }
    }
}
