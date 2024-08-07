using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.Repository
{
    public interface IPerformanceRepository
    {
        ICollection<Performance> GetPerformances();

        Performance GetPerformance(int id);

        bool HasPerformance(int id);

        
    }
}
