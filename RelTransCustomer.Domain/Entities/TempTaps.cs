using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempTaps
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string PriSec { get; set; } = null!;

    public int WindingNo { get; set; }

    public int? TapCount { get; set; }

    public int TapNo { get; set; }

    public double? TapVolts { get; set; }

    public double? ConCsa { get; set; }

    public double? WireInsY { get; set; }

    public double? WireInsX { get; set; }

    public double? WireRows { get; set; }

    public double? WireCols { get; set; }

    public double? IntLayerIns { get; set; }

    public double? Ducts { get; set; }

    public int? DuctType { get; set; }

    public double? DuctQty { get; set; }

    public double? EdgeStripLength { get; set; }

    public double? EdgeStripThick { get; set; }

    public double? EdgeStripPar { get; set; }

    public double? EdgeStripQty { get; set; }

    public double? EdgeStripTotThick { get; set; }

    public double? EdgeStripLeft { get; set; }

    public double? EdgeStripRight { get; set; }

    public double? EdgeStripLong { get; set; }

    public double? EdgeStripArea { get; set; }

    public double? EdgeStripVolume { get; set; }

    public double? EdgeStripMass { get; set; }

    public double? WindType { get; set; }

    public double? Clength { get; set; }

    public double? CoilDir { get; set; }

    public double? StartSide { get; set; }

    public double? LeadsSide { get; set; }

    public string? Leads { get; set; }

    public double? LeadLength { get; set; }

    public string? LeadColour { get; set; }

    public string? InterLayerInsMaterial { get; set; }

    public string? DuctsMaterial { get; set; }

    public string? EdgeStripsMaterial { get; set; }

    public double? LeadBarWidth { get; set; }

    public double? LeadBarThick { get; set; }

    public int? WireMetal { get; set; }

    public decimal? WireCost { get; set; }

    public double? DummyTurn { get; set; }

    public double? WindFactor { get; set; }

    public double? WireLock { get; set; }

    public string? WireCovering { get; set; }

    public string? Txposition { get; set; }

    public double? WireShape { get; set; }

    public double? WireWidth { get; set; }

    public double? WireHeight { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public double? IntLayerWraps { get; set; }

    public string? LugsBmaterial { get; set; }

    public string? LugsTmaterial { get; set; }

    public int? LugsBqty { get; set; }

    public int? LugsTqty { get; set; }
}
