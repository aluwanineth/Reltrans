using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempBom
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public string? DexPart0 { get; set; }

    public string? Description2 { get; set; }

    public string? ProductId3 { get; set; }

    public string? Units5 { get; set; }

    public decimal? Cost6 { get; set; }

    public double? Waste7 { get; set; }

    public double? Qty4 { get; set; }

    public string? StandardUnits11 { get; set; }

    public decimal? TotalAmount9 { get; set; }

    public decimal? Cpa8 { get; set; }

    public int? EnvisageRef12 { get; set; }

    public int BomLine { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }
}
