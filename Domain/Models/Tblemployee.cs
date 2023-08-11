using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Tblemployee
{
    public int Empid { get; set; }

    public string? Ename { get; set; }

    public int Deptid { get; set; }

    public decimal Salary { get; set; }

    public int Managerid { get; set; }

    public string Phoneno { get; set; } = null!;
}
