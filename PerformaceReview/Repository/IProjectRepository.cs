using PerformaceReview.Models;

namespace PerformaceReview.Repository
{
    public interface IProjectRepository
    {
        ICollection<Project> GetProjects();
    }
}
