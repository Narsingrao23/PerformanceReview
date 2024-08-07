using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.Repository
{
    public class PerformanceRepository : IPerformanceRepository
    {
        private readonly PerformanceReviewContext _context;

        public PerformanceRepository(PerformanceReviewContext context)
        {
            _context = context;
        }
        public ICollection<Performance> GetPerformances()
        {
            return _context.Performances.OrderBy(p => p.Id).ToList();
        }

        public Performance GetPerformance(int id)
        {
            return _context.Performances.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool HasPerformance(int id)
        {
            return _context.Performances.Any(p => p.Id == id);
        }
    }
}
