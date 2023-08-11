using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblEmpMaster
{
    public int EmpId { get; set; }

    public string EmpCode { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public int CityId { get; set; }

    public int StateId { get; set; }

    public bool IsActive { get; set; }

    public byte CommandId { get; set; }

    public int CreateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateIp { get; set; } = null!;

    public int UpdateBy { get; set; }

    public DateTime UpdateDate { get; set; }

    public string UpdateIp { get; set; } = null!;

    public int? DepartmentId { get; set; }
}
