using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblDeptMasterDetail
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
