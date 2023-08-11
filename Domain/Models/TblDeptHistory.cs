using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class TblDeptHistory
{
    public int HistoryId { get; set; }

    public int CommandId { get; set; }

    public int? DeptId { get; set; }

    public string? OldDeptName { get; set; }

    public string? NewDeptName { get; set; }

    public string? OldDeptDescription { get; set; }

    public string? NewDeptDescription { get; set; }

    public string? HistoryBy { get; set; }

    public DateTime? HistoryDate { get; set; }

    public string? HistoryIp { get; set; }
}
