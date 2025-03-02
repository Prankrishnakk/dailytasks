using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Model;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _studentService.Get();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Add(Student Addstudent)
        {
            var res = _studentService.Add(Addstudent);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult Update(Student Updatestudent)
        {
            var res = _studentService.Update(Updatestudent);
            if (res == "student not found")
            {
                return BadRequest(res);
            }
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            var res = _studentService.Delete(id);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult SearchByName(string name)
        {
            var res = _studentService.SearchByName(name);
            if (res == null)
            {
                return BadRequest("student not Found");
            }
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var res =_studentService.Login(username, password);
            if (res) 
            {
                return Ok("Login Succesfull");
            }
            return NotFound("Login Unsuccesfull");
        }  
    }
}
