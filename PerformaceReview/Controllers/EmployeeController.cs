using Microsoft.AspNetCore.Mvc;
using PerformanceReviewData.DTO;
using PerformanceReviewData.Models;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;
using System.Diagnostics.Metrics;

namespace PerformaceReview.Controllers  
{
    [Route("api/")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("AllEmployee")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Employee>))]
        public IActionResult GetallEmployees()
        {
            var employees = _employeeService.GetEmployees();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(employees);
        }
        [HttpGet("Employeebyid/{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Employee>))]
        public IActionResult GetEmployee([FromRoute]int Id)
        {
            if (!_employeeService.IsEmployeeActive(Id))
                return NotFound();

            var employees = _employeeService.GetEmployee(Id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(employees);



        }
        [HttpPost("NewEmployee")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateEmployee([FromBody] EmployeeDto employee)
        {
            if (CreateEmployee == null)
                return BadRequest(ModelState);

            var emp = _employeeService.CreateOneEmployee(employee);

            //if (employee != null)
            //{
            //    ModelState.AddModelError("", "Country already exists");
            //    return StatusCode(422, ModelState);
            //}

            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);
            

            return GetEmployee(emp.Id);
        }

        [HttpPut("updateEmployeeEmployeeId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult UpdateEmployee(int Id, [FromBody] EmployeeDto employee)
        {
            if (employee == null)
                return BadRequest(ModelState);
            
            if (Id != employee.Id)
                return BadRequest(ModelState);
            
            if(!_employeeService.IsEmployeeActive(Id))
                return NotFound(); 

            var emp = _employeeService.UpdateOneEmployee(employee);


            //if (employee != null)
            //{
            //    ModelState.AddModelError("", "Country already exists");
            //    return StatusCode(422, ModelState);
            //}

            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);


            return GetEmployee(emp.Id);
        }

        [HttpDelete("deleteEmployeeEmployeeId")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult DeleteEmployee(int Id)
        {

            if (!_employeeService.IsEmployeeActive(Id))
                return NotFound();

             var emp = _employeeService.DeleteOneEmployee(Id);

            

        


            return NoContent();
        }
    }
}