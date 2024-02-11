using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignDrawingScheduleLog
{
    public int Id { get; set; }

    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string? JobNo { get; set; }

    public string Product { get; set; } = null!;

    public string Part { get; set; } = null!;

    public string Event { get; set; } = null!;

    public string Before { get; set; } = null!;

    public string After { get; set; } = null!;

    public string User { get; set; } = null!;

    public string Date { get; set; } = null!;
}
