using System;
using System.Collections.Generic;

namespace PerformanceReviewData.Models;

public partial class Employee
{
    public int Id { get; set; }
  
    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public int Age { get; set; }

    public string Position { get; set; } = null!;

    public string Contact { get; set; } = null!;
}
