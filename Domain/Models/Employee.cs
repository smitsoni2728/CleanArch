using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;
}
