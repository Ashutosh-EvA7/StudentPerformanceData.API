using System;
using System.Collections.Generic;

namespace SPD.Entity.Models;

public partial class Marksheet
{
    public Guid MarkSheetId { get; set; }

    public Guid? StudentId { get; set; }

    public string? Subject { get; set; }

    public decimal? TotalMark { get; set; }

    public decimal? MarksObtained { get; set; }

    public virtual StudentMaster? Student { get; set; }
}
