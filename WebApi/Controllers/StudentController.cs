using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _studentService;
        public StudentController(IStudentService studentService) 
        {
            _studentService = studentService;
        }
        [HttpGet]
        public ICollection<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

    }
}
