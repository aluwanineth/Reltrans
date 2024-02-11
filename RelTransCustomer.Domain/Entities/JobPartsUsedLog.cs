using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class JobPartsUsedLog
{
    public int Id { get; set; }

    public string SpecNo { get; set; } = null!;

    public string JobNo { get; set; } = null!;

    public string Output { get; set; } = null!;

    public int OutputStage { get; set; }

    public string User { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Reason { get; set; }
}
