using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public interface IPerformanceRepository
    {
        ICollection<Performance> GetPerformances();
    }
}
