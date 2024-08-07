using AutoMapper;
using PerformanceReviewData.DTO;
using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewService.Mapper
{
   public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<ProjectDto, Project>();
            CreateMap<PerformanceDto, Performance>();
            CreateMap<Project, ProjectDto>();
            CreateMap<Performance, PerformanceDto>();
        }
    }
}
