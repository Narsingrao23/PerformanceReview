using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public class PerformanceRepository : IPerformanceRepository
    {
        private readonly PerformanceReviewContext _context;

        public PerformanceRepository(PerformanceReviewContext context) 
        {
            _context=context;
        }
        public ICollection<Performance> GetPerformances()
        {
            return _context.Performances.OrderBy(p => p.Id).ToList();
        }
    }
}
