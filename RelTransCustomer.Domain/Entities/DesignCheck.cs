using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCheck
{
    public int RecId { get; set; }

    public string? SpecNo { get; set; }

    public int? RevNo { get; set; }

    public string? JobNo { get; set; }

    public string? RequestedBy { get; set; }

    public DateTime? RequestedOn { get; set; }

    public string? DesignerNotes { get; set; }

    public string? Status { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public string? ManagerNotes { get; set; }
}
