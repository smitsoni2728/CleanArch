using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblEmployeeMaster
{
    public int Empid { get; set; }

    public string? Empcode { get; set; }

    public string Empname { get; set; } = null!;

    public string EmpfatherName { get; set; } = null!;

    public string Empdetails { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime CreateDateTime { get; set; }

    public string CreateIp { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateDateTime { get; set; }

    public string UpdateIp { get; set; } = null!;

    public int? DeptId { get; set; }
}
