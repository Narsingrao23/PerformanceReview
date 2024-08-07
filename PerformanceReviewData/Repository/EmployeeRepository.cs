using Microsoft.EntityFrameworkCore;
using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.Repository
{
    public class EmployeeRepository :  IEmployeeRepository
    {
        public readonly PerformanceReviewContext _context;

        public EmployeeRepository(PerformanceReviewContext context)
        {
            _context = context;
        }

        public ICollection<Employee> GetEmployees()
        {
            return _context.Employees.OrderBy(p => p.Id).ToList();
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Where(p => p.Id  == id).FirstOrDefault();
        }

        public bool IsEmployeeActive(int id)
        {
            return _context.Employees.Any(p => p.Id == id);
        }

        public bool CreateEmployee(Employee employee)
        {
            _context.Add(employee);
            return save();
        }

        public bool save()
        {
            var save = _context.SaveChanges();
            return save > 0 ? true : false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            return save();
        }

        public bool DeleteEmployee(Employee employee)
        {
            //var emp = _context.Employees.FirstOrDefault(p =>p.Id == id);
            //if (emp != null)
            //{
            //    _context.Remove(emp);
            //    _context.SaveChanges();
            //    return save();
            //}
            //else { 
            //return  false;
            //}
            _context.Remove(employee);
            return save();
            
        }
    }
}
