using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Employee1
{
    public int EmpNum { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}
