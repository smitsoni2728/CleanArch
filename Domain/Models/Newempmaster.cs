using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Newempmaster
{
    public int Empid { get; set; }

    public string Empname { get; set; } = null!;

    public int Deptid { get; set; }

    public decimal Empsalary { get; set; }

    public int Anagerid { get; set; }

    public string Phoneno { get; set; } = null!;
}
