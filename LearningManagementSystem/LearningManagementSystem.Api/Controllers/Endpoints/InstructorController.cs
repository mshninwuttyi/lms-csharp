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

    }
}
