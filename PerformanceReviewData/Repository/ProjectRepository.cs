using PerformanceReviewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly PerformanceReviewContext _context;

        public ProjectRepository(PerformanceReviewContext context)
        {
            _context = context;
        }

        public ICollection<Project> GetProjects()
        {
            return _context.Projects.OrderBy(p => p.ProjId).ToList();
        }
    }
}
