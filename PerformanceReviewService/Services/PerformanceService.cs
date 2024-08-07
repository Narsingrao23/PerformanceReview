using AutoMapper;
using PerformanceReviewData.DTO;
using PerformanceReviewData.Repository;
using PerformanceReviewService.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewService.Services
{
    public class PerformanceService : IPerformanceService
    {
        private readonly IPerformanceRepository _repository;
        private readonly IMapper _mapper;

        public PerformanceService(IPerformanceRepository repository, IMapper mapper)
        {
                _repository=repository;
                _mapper=mapper;
        }

        public ICollection<PerformanceDto> GetPerformances()
        {
            var performance = _repository.GetPerformances();
            var obj = _mapper.Map<ICollection<PerformanceDto>>(performance);
            return obj;
        }
        
        public PerformanceDto GetPerformance(int id) 
        {
       
            var performance = _repository.GetPerformance(id);
            var obj = _mapper.Map<PerformanceDto>(performance);
            return obj;
        }

        public bool HasPerformance(int id) 
        {
            return _repository.HasPerformance(id);
        }
    }
}
