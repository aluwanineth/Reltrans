using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCheckLog
{
    public int RecId { get; set; }

    public string? SpecNo { get; set; }

    public int? RevNo { get; set; }

    public string? JobNo { get; set; }

    public string? Designer { get; set; }

    public DateTime? Date { get; set; }

    public string? Notes { get; set; }

    public string? Status { get; set; }

    public string? Action { get; set; }
}
