using LearningManagementSystem.Domain.Services.InstructorServices;
using LearningManagementSystem.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LearningManagementSystem.Api.Controllers.Endpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorsController(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        [HttpPost("Register")]
        public IActionResult CreateInstructors(InstructorViewModels reqModel)
        {
            var items = _instructorRepository.CreateInstructor(reqModel);
            return Ok(items);
        }

        [HttpGet]
        public IActionResult GetInstructors()
        {
            var items = _instructorRepository.GetInstructors();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetInstructorById(int id)
        {
            var items = _instructorRepository.GetInstructorById(id);
            return Ok(items);
        }

    }
}
