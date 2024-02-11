using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignUnlock
{
    public int Id { get; set; }

    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string? Reason { get; set; }

    public string? Ncrno { get; set; }

    public DateTime? Date { get; set; }

    public string? User { get; set; }

    public string? Designer { get; set; }
}
