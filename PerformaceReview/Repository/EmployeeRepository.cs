using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly PerformanceReviewContext _context;

        public EmployeeRepository(PerformanceReviewContext context) 
        {
            _context=context;
        }

        public ICollection<Employee> GetEmployees() 
        {
            return _context.Employees.OrderBy(p => p.Id).ToList();     
        }
    }
}
