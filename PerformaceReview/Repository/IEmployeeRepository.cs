using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public interface IEmployeeRepository
    {
        ICollection<Employee> GetEmployees();
    }
}
