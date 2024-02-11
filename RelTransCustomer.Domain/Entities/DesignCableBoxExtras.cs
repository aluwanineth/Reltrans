using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCableBoxExtras
{
    public int RecId { get; set; }

    public string? SpecNo { get; set; }

    public int? RevNo { get; set; }

    public string? PriSec { get; set; }

    public string? Type { get; set; }

    public string? Material { get; set; }

    public float? Gauge { get; set; }

    public float? Width { get; set; }

    public float? Length { get; set; }

    public float? Qty { get; set; }
}
