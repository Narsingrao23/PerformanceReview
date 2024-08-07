using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly PerformanceReviewContext _context;

        public ProjectRepository(PerformanceReviewContext context) 
        {
            _context=context;
        }

        public ICollection<Project> GetProjects() 
        { 
            return _context.Projects.OrderBy(p => p.ProjId).ToList();
        }
    }
}
