using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblDeptMaster
{
    public int DepartmentTypeId { get; set; }

    public string DepartmentTypeCode { get; set; } = null!;

    public string DepartmentTypeName { get; set; } = null!;

    public bool IsActive { get; set; }

    public byte CommandId { get; set; }

    public int CreateBy { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateIp { get; set; } = null!;

    public int UpdateBy { get; set; }

    public DateTime UpdateDate { get; set; }

    public string UpdateIp { get; set; } = null!;
}
