using Microsoft.AspNetCore.Mvc;
using PerformanceReviewData.Models;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;
using PerformanceReviewService.Services;

namespace PerformaceReview.Controllers
{

    [Route("api/controller")]
    [ApiController]
    public class PerformanceController : Controller
    {
        private readonly IPerformanceService _performanceService;

        public PerformanceController(IPerformanceService performanceService)
        {
            _performanceService = performanceService;
        }

        [HttpGet("Performance")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Performance>))]

        public IActionResult GetPerformances()
        {
            var performances = _performanceService.GetPerformances();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(performances);
        }
        [HttpGet("Performance/by id")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Performance>))]
        public IActionResult GetPerformance(int id)
        {
            if(!_performanceService.HasPerformance(id))
                return NotFound();

            var performance = _performanceService.GetPerformance(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(performance);
        }
    }
}
