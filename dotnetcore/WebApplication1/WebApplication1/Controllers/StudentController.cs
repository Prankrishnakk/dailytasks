using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IStudentsService _StudentsService;
        public StudentController(IStudentsService studentsService)
        {
            _StudentsService = studentsService;
        }

        [HttpGet]
        public IActionResult Get()
        { 
            var res = _StudentsService.Get();
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Add(Students Addstudent)
        { 
            var res = _StudentsService.Add(Addstudent);
            return Ok(res);

        }
        [HttpPut]
        public IActionResult Update(Students Updatestudent)
        {
            var res = _StudentsService.Update(Updatestudent);
            {
                if (res == "student not found") 
                {
                    return NotFound(res);
                }
                return Ok(res);
            }
           
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            var res = _StudentsService.Delete(id);
            return Ok(res); 
        }


    }

}
