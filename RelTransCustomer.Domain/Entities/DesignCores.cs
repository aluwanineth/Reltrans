using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCores
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int? CoreShape { get; set; }

    public string? Corename { get; set; }

    public string? Label { get; set; }

    public double? Core1 { get; set; }

    public double? Core2 { get; set; }

    public double? Wood1 { get; set; }

    public double? Wood2 { get; set; }

    public double? Coil1 { get; set; }

    public double? Coil2 { get; set; }

    public double? FeDiameter { get; set; }

    public double? CoreLength { get; set; }

    public double? CoilLength { get; set; }

    public double? PhaseCentres { get; set; }

    public double? FeCsa { get; set; }

    public double? CoreMass { get; set; }

    public int? Divide { get; set; }

    public string? CoreMaterial { get; set; }

    public string? BobbinRef { get; set; }

    public string? CclampRef { get; set; }

    public string? VentbRef { get; set; }

    public string? TankRef { get; set; }

    public double? Flux { get; set; }

    public int? SeriesPar { get; set; }

    public double? WattsPerKg { get; set; }

    public double? CoreLoss { get; set; }

    public bool? StandardCore { get; set; }

    public double? CoilGap { get; set; }

    public int? CoreSteps { get; set; }

    public double? CoreChop { get; set; }

    public double? OvalWidth { get; set; }

    public double? OvalStack { get; set; }

    public double? OvalCutaway { get; set; }

    public double? YokeWidth { get; set; }

    public double? ThinWidth { get; set; }

    public string? FormerMaterial { get; set; }

    public double? FormerGuage { get; set; }

    public int? FormerWraps { get; set; }

    public double? FormerTotThickness { get; set; }

    public string? FlangeMaterial { get; set; }

    public double? FlangeWidth { get; set; }

    public double? FlangeHeight { get; set; }

    public double? FlangeGuage { get; set; }

    public string? BobbinProductId { get; set; }

    public string? BobbinLabel { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public string? CoreFeetSpec { get; set; }

    public double? CoreFeetHeight { get; set; }

    public double? CoreFeetWidth { get; set; }

    public double? CoreFeetGuage { get; set; }

    public double? CoreFeetLength { get; set; }

    public double? CoreInsGuage { get; set; }

    public string? CoreInsMaterial { get; set; }

    public string? WedgeMaterial { get; set; }

    public double? CoilWedgeWidth { get; set; }

    public double? CoilWedgeLength { get; set; }

    public double? CoilWedgeGuage { get; set; }

    public string? ChildBobbins { get; set; }

    public string? ChildCclamps { get; set; }

    public bool? IsPart { get; set; }

    public string? Device { get; set; }

    public string? LamsMaterial { get; set; }

    public int? LimbCount { get; set; }

    public string? LimbClamps { get; set; }

    public bool? CableDuct { get; set; }

    public double? YokeCenter { get; set; }
}
