using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.Repository
{
        public interface IEmployeeRepository
        {
            ICollection<Employee> GetEmployees();
            Employee GetEmployee(int id);

        bool IsEmployeeActive(int id);

        bool CreateEmployee(Employee employee);

        bool save();

        bool UpdateEmployee(Employee employee);

        bool DeleteEmployee(Employee employee); 
 
        }
    
}
