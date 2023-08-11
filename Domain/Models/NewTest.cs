using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class NewTest
{
    public int DId { get; set; }

    public string FullName { get; set; } = null!;

    public string FName { get; set; } = null!;

    public string MName { get; set; } = null!;

    public string LName { get; set; } = null!;

    public string DcrckitSrNo { get; set; } = null!;
}
