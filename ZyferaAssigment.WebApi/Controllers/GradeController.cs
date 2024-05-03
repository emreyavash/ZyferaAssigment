using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZyferaAssigment.Business.Abstract;

namespace ZyferaAssigment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService _gradeService;

        public GradeController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet("GradeGetAll")]
        public IActionResult GradeGetAll() { 
            var result = _gradeService.GetAll();
            return Ok(result);
        }
    }
}
