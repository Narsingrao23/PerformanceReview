using PerformanceReviewData.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewService.ServiceInterfaces
{
    public interface IProjectService
    {
        ICollection<ProjectDto> GetProjects();
    }
}
