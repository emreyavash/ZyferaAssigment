using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZyferaAssigment.Business.Abstract;
using ZyferaAssigment.Entity.Concrete;
using ZyferaAssigment.Entity.DTO;

namespace ZyferaAssigment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IGradeService _gradeService;

        public StudentController(IStudentService studentService, IGradeService gradeService)
        {
            _studentService = studentService;
            _gradeService = gradeService;
        }

        [HttpPost("StudentGradeAdd")]
        public IActionResult StudentGradeAdd(StudentDto studentDto)
        {
            var checkStudent = _studentService.GetByStdNumber(studentDto.StdNumber);
            if (checkStudent == null)
            {
                var student = new Student
                {
                    Name = studentDto.Name,
                    Surname = studentDto.Surname,
                    StdNumber = studentDto.StdNumber,
                };

                _studentService.Add(student);
            }


            foreach (var courseGrades in studentDto.Grades.GroupBy(g => g.Code))
            {
                var courseCode = courseGrades.Key;
                var averageGrade = ((int)courseGrades.Average(g => g.Value));
                var grade = new Grade
                {
                    Code = courseCode,
                    Value = averageGrade,
                    StdNumber = studentDto.StdNumber,
                };
                _gradeService.Add(grade);

            }


            return Ok("İşlem Başarılı");
        }
        [HttpGet("StudentGetAll")]
        public IActionResult StudentGetAll()
        {
            var result = _studentService.GetAll();
            return Ok(result);
        }
    }
}
