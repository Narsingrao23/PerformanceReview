using Microsoft.AspNetCore.Mvc;
using PerformanceReviewData.Models;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;

namespace PerformaceReview.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class ProjectController : Controller
    {
        
private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService=projectService;
        }

        [HttpGet("Project")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Project>))]

        public IActionResult GetProjects()
        {
            var projects = _projectService.GetProjects();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(projects);
        }
    }
}
