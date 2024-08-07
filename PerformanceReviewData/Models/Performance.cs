using System;
using System.Collections.Generic;

namespace PerformanceReviewData.Models;

public partial class Performance
{
    public int? Id { get; set; }

    public int? ProjId { get; set; }

    public float Rating { get; set; }

    public virtual Employee? IdNavigation { get; set; }

    public virtual Project? Proj { get; set; }
}
