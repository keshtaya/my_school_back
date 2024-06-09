using Microsoft.AspNetCore.Mvc;
using my_school.Features.Students.Models.DTOs;
using my_school.Features.Students.Services;

namespace my_school.Features.Students
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentsController : ControllerBase
    {

        readonly NewStudentService _newStudentService;
        readonly StudentsService _studentsService;

        public StudentsController(StudentsService studentsService, NewStudentService newStudentService)
        {
            _newStudentService = newStudentService;
            _studentsService = studentsService;
        }

        [HttpGet]
        [ActionName("")]
        public async Task<IActionResult> Get()
        {
            var students = await _studentsService.FetchAll();
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] NewStudentRequestModel NewStudentRequest)
        {
            var createdStudent = await _newStudentService.Register(NewStudentRequest);
            return Ok(createdStudent);
        }

    }
}
