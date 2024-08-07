using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.DTO
{
    public class ProjectDto
    {
        public int ProjId { get; set; }

        public string ProjName { get; set; } = null!;

        public string ProjLocation { get; set; } = null!;

        public string ProjManager { get; set; } = null!;
    }
}
