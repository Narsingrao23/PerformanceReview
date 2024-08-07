using AutoMapper;
using PerformanceReviewData.DTO;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewService.Services
{
    public class ProjectService : IProjectService 
    {
        private readonly IProjectRepository _repository;
        private readonly IMapper _mapper;

        public ProjectService(IProjectRepository repository, IMapper mapper) 
        {
            _repository=repository;
            _mapper=mapper;
        }

         public ICollection<ProjectDto> GetProjects() 
        {
            var project = _repository.GetProjects();
            var obj = _mapper.Map<ICollection<ProjectDto>>(project);
            return obj;
        }

        
    }
}
