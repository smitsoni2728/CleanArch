using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Empdepart
{
    public int Id { get; set; }

    public string? Employeename { get; set; }

    public int? Departid { get; set; }
}
