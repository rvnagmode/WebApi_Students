using Microsoft.AspNetCore.Mvc;

using WebApi_Student.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentServices _studservice;
        public StudentController(IStudentServices studServices)
        {
            _studservice = studServices;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Student/GetStudent")]
        public IActionResult GetStudent()
        {
            return new ObjectResult(_studservice.GetAllStudent());
        }
    }
}
