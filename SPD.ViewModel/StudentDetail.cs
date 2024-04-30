using SPD.Entity.Models;
using SPD.ViewModel;
using System;
using System.Collections.Generic;

namespace SPD.ViewModel;

public partial class StudentDetail
{
    public Guid StudentId { get; set; }

    public string? StudentName { get; set; }

    public DateOnly? StudentJoinDate { get; set; }

    public int? Class { get; set; }

    public virtual ICollection<Marksheet> Mark { get; set; } = [];
}
