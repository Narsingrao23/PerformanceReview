using PerformanceReviewData.DTO;
using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace PerformanceReviewService.ServiceInterfaces
{
    public interface IEmployeeService
    {
        ICollection<EmployeeDto> GetEmployees();
        
        EmployeeDto GetEmployee(int id);

        bool IsEmployeeActive(int id);

        EmployeeDto CreateOneEmployee(EmployeeDto employee);

        bool save();

        EmployeeDto UpdateOneEmployee(EmployeeDto employee);

        bool DeleteOneEmployee(int id);
    }
}
