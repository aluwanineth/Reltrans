using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempCablebox
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public string PriSec { get; set; } = null!;

    public int BoxNo { get; set; }

    public int? BoxType { get; set; }

    public double? BoxWidth { get; set; }

    public double? BoxHeight { get; set; }

    public double? BoxDepth { get; set; }

    public double? BoxRim { get; set; }

    public double? BoxGuage { get; set; }

    public double? ExtBoxWidth { get; set; }

    public double? ExtBoxHeight { get; set; }

    public double? ExtBoxDepth { get; set; }

    public double? ExtBoxRim { get; set; }

    public double? ExtBoxGuage { get; set; }

    public double? BushingCutout { get; set; }

    public double? BushingDia { get; set; }

    public double? BushingHeight { get; set; }

    public int? BushingQty { get; set; }

    public double? BushingPitch { get; set; }

    public double? BushingLastPitch { get; set; }

    public double? BushingToTop { get; set; }

    public double? BushingInsideLength { get; set; }

    public double? BushingOutsideLength { get; set; }

    public double? PocketTop { get; set; }

    public double? PocketBottom { get; set; }

    public double? PocketWidth { get; set; }

    public string? CboxLidType { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public string? StandardBox { get; set; }

    public string? StandardPocket { get; set; }

    public int? PocketBushingQty { get; set; }

    public double? PocketBushingCutout { get; set; }

    public double? PocketBushingDia { get; set; }

    public double? PocketBushingPitch { get; set; }

    public double? PocketBushingInsideLength { get; set; }

    public double? PocketBushingOutsideLength { get; set; }

    public string? IndoorBushingMaterial { get; set; }

    public string? OutdoorBushingMaterial { get; set; }

    public double? PocketBushingHeight { get; set; }

    public int? BushingBoxRows { get; set; }

    public int? BushingPocketRows { get; set; }

    public bool? Stdcbox { get; set; }

    public bool? Stdpocket { get; set; }

    public double? CboxRimBoltPitch { get; set; }

    public int? CboxRimBoltQty { get; set; }

    public string? CboxRimBoltSpec { get; set; }

    public int? PocketBushingToTop { get; set; }

    public string? TermPlateMaterial { get; set; }

    public double? TermPlateGauge { get; set; }

    public string? GlandPlateMaterial { get; set; }

    public double? GlandPlateGauge { get; set; }
}
