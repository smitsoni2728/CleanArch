using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Newempmast
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public int DeptId { get; set; }

    public decimal EmpSalary { get; set; }

    public int ManagerId { get; set; }

    public string Phoneno { get; set; } = null!;

    public void ForEach(Action<object> value)
    {
        throw new NotImplementedException();
    }

    public object Select(Func<object, bool> value)
    {
        throw new NotImplementedException();
    }
}
