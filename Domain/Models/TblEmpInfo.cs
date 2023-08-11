using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblEmpInfo
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public string EmpDepartment { get; set; } = null!;

    public int EmpPhoneNumber { get; set; }
}
