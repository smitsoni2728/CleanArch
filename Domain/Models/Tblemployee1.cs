using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Tblemployee1
{
    public int Empid { get; set; }

    public string Ename { get; set; } = null!;

    public int Deptid { get; set; }

    public decimal Salary { get; set; }

    public int Managerid { get; set; }

    public string Phoneno { get; set; } = null!;
}
