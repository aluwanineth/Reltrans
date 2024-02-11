using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignRads
{
    public int Sqlid { get; set; }

    public string? SpecNo { get; set; }

    public int RevNo { get; set; }

    public int? No { get; set; }

    public string? Material { get; set; }

    public string? PartRange { get; set; }

    public int? Position { get; set; }

    public int? PortCount { get; set; }

    public float? PortPitch { get; set; }

    public string? PortShape { get; set; }

    public float? PortInnerDia { get; set; }

    public float? PortLength { get; set; }

    public float? PortWidth { get; set; }

    public float? PortHeight { get; set; }

    public float? PortGauge { get; set; }

    public float? PortVerticalCentres { get; set; }

    public string? TubeType { get; set; }

    public int? TubeCount { get; set; }

    public int? TubeRows { get; set; }

    public float? TubeLength { get; set; }

    public float? TubePitch { get; set; }

    public float? TubeGauge { get; set; }

    public float? TubeHeaderGauge { get; set; }

    public int? FinCount { get; set; }

    public float? FinLength { get; set; }

    public float? FinHeight { get; set; }

    public float? FinWidth { get; set; }

    public float? FinPitch { get; set; }

    public float? FinGauge { get; set; }

    public float? FinThickness { get; set; }

    public string? TopBoxShape { get; set; }

    public float? TopBoxWidth { get; set; }

    public float? TopBoxLength { get; set; }

    public float? TopBoxFrontHeight { get; set; }

    public float? TopboxRearHeight { get; set; }

    public float? TopBoxFromCorner { get; set; }

    public float? TopBoxFromRim { get; set; }

    public float? TopBoxGauge { get; set; }

    public string? BottomBoxShape { get; set; }

    public float? BottomBoxWidth { get; set; }

    public float? BottomBoxLength { get; set; }

    public float? BottomBoxFrontHeight { get; set; }

    public float? BottomBoxRearHeight { get; set; }

    public float? BottomBoxGauge { get; set; }

    public float? BottomBoxFromFloor { get; set; }
}
