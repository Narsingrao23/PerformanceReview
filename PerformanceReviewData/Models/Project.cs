using System;
using System.Collections.Generic;

namespace PerformanceReviewData.Models;

public partial class Project
{
    public int ProjId { get; set; }

    public string ProjName { get; set; } = null!;

    public string ProjLocation { get; set; } = null!;

    public string ProjManager { get; set; } = null!;
}
