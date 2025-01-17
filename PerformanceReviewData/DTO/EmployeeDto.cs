﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewData.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;

        public int Age { get; set; }

        public string Position { get; set; } = null!;

        public string Contact { get; set; } = null!;

    }
}
