using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class EmployeeMaster
{
    public decimal EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpCode { get; set; }

    public string? EmpUsername { get; set; }

    public string? EmpPassword { get; set; }

    public decimal? EmpDeptid { get; set; }

    public string? EmpPhone { get; set; }

    public string? EmpAddr { get; set; }

    public string? EmpType { get; set; }

    public string? EmpMail { get; set; }

    public decimal? EmpCreatedId { get; set; }

    public DateTime? EmpCreatedDate { get; set; }

    public decimal? EmpModifiedId { get; set; }

    public DateTime? EmpModifiedDate { get; set; }
}
