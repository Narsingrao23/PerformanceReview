using AutoMapper;
using PerformanceReviewData.DTO;
using PerformanceReviewData.Models;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewService.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, IMapper mapper)
        {
            _repo = repository;
            _mapper = mapper;
        }

        public ICollection<EmployeeDto> GetEmployees()
        {
            var employee = _repo.GetEmployees();
            var obj = _mapper.Map<ICollection<EmployeeDto>>(employee);
            //employee.Select(x =>  new EmployeeDto
            //{
            //  Age = x.Age,
            //  Id = x.Id,
            //  LastName = x.LastName,
            //  FirstName = x.FirstName,
            //  Contact = x.Contact,
            //  Position = x.Position,


            //}).ToList();



            return obj;

        }
        public EmployeeDto GetEmployee(int id)
        {

            var employee = _repo.GetEmployee(id);
            var obj = _mapper.Map<EmployeeDto>(employee);
            return obj;

        }
        public bool IsEmployeeActive(int id)
        {
              return _repo.IsEmployeeActive(id);

        }

        public EmployeeDto CreateOneEmployee(EmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);

            // Repo -> Save
            _repo.CreateEmployee(emp);
            _repo.save();

            // Entity -> Dto
            return _mapper.Map<EmployeeDto>(emp);
        }


        public bool save()
        {
            return _repo.save();
        }

        public EmployeeDto UpdateOneEmployee(EmployeeDto employee)
        {
            var emp = _mapper.Map<Employee>(employee);
            _repo.UpdateEmployee(emp);

            return _mapper.Map<EmployeeDto>(emp);


        }

        public bool DeleteOneEmployee(int id)
        {

            var emp = _repo.DeleteEmployee(GetEmployeeById(id));

            return true;
        }

        public Employee GetEmployeeById(int id)
        {
           var rep = _repo.GetEmployee(id);
            return rep; 
        }

             
      
    }




}

