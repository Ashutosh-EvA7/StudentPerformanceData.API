using System;
using System.Collections.Generic;

namespace SPD.Entity.Models;

public partial class StudentMaster
{
    public Guid StudentId { get; set; }

    public string? StudentName { get; set; }

    public DateOnly? StudentJoinDate { get; set; }

    public int? Class { get; set; }

    public virtual ICollection<Marksheet> Marksheets { get; set; } = [];
}
