using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Model;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentService _StudentService;
        public StudentController(IStudentService studentService)
        {
            _StudentService = studentService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var res = _StudentService.Get();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Add(Student Addstudent)
        {
            var res = _StudentService.Add(Addstudent);
            return Ok(res);
        }
        [HttpPut]

        public IActionResult Update(Student Updatestudent)
        {
            var res = _StudentService.Update(Updatestudent);
            {
                if (res == "student not found")
                {
                    return BadRequest(res);
                }
                return Ok(res);
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            var res = _StudentService.Delete(id);
            
            return Ok(res);
        }
        [HttpGet("Search")]

        public IActionResult SearchByName(String name)
        {
            var res = _StudentService.SearchByName(name);
            if (res == null)
            {
                return BadRequest("student not Found");
            }
            return Ok(res);
        }
        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            var res = _StudentService.Login(username, password);
            if (res)
            {
                return Ok("Login is Succesfull");
            }
            return Unauthorized("Login Unsuccesfull");
        }
    } 
} 
