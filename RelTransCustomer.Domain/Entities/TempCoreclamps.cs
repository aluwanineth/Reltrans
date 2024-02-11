using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempCoreclamps
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public string? FrameSpec { get; set; }

    public string? FramePos { get; set; }

    public int? FrameNo { get; set; }

    public double? TopWidth { get; set; }

    public double? BottomWidth { get; set; }

    public double? Height { get; set; }

    public double? Guage { get; set; }

    public double? Length { get; set; }

    public double? CutoutPriTopWidth { get; set; }

    public double? CutoutPriTopDepth { get; set; }

    public double? CutoutPriBottomWidth { get; set; }

    public double? CutoutPriBottomDepth { get; set; }

    public double? CutoutSecTopWidth { get; set; }

    public double? CutoutSecTopDepth { get; set; }

    public double? CutoutSecBottomWidth { get; set; }

    public double? CutoutSecBottomDepth { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public double? CoreInsGuage { get; set; }

    public double? MountHoleSide { get; set; }

    public string? MountHolePositions { get; set; }

    public double? VerTieLength { get; set; }

    public double? VerTieMaterial { get; set; }

    public double? VerTieSize { get; set; }

    public double? VerTieQty { get; set; }

    public string? VerTieStyle { get; set; }

    public int? HorTieQty { get; set; }

    public double? HorTieSize { get; set; }

    public string? HorTieMaterial { get; set; }

    public double? HorTieLength { get; set; }

    public string? CoreFeetMaterial { get; set; }

    public string? VerTieRodMaterial { get; set; }

    public string? HorTieRodMaterial { get; set; }

    public double? Vertie1Length { get; set; }

    public double? Hortie1Length { get; set; }

    public double? HorTie2Length { get; set; }

    public double? FrameStiffenerLength { get; set; }

    public double? CoilSupportLength { get; set; }

    public string? CoilSupportSinDoub { get; set; }

    public string? CoreFeetSpec { get; set; }

    public double? CoreFeetHeight { get; set; }

    public double? CoreFeetWidth { get; set; }

    public double? CoreFeetGuage { get; set; }

    public double? CoreFeetLength { get; set; }

    public string? CoreClampMaterial { get; set; }

    public string? StiffenerMaterial { get; set; }

    public string? CoilSuppMaterial { get; set; }

    public string? CoreFeetMaterial1 { get; set; }

    public string? VerTieRodMaterial1 { get; set; }

    public string? HorTieRodMaterial1 { get; set; }

    public double? TswitchHoleX { get; set; }

    public double? TswitchHolY { get; set; }

    public double? TswitchHoleCentre { get; set; }

    public double? TswitchHoleDia { get; set; }

    public double? DoveLockPosDia { get; set; }

    public double? DoveLockHoleDia { get; set; }

    public string? CutSupportType { get; set; }

    public double? CutSupportX { get; set; }

    public double? CutSupportY { get; set; }

    public double? CutSupportDia { get; set; }

    public double? MountHoleX { get; set; }

    public double? MountHoleY { get; set; }

    public double? MountHoleDia { get; set; }

    public double? LiftHoleToEdge { get; set; }

    public double? LiftHoleToTop { get; set; }

    public double? LiftHoleDia { get; set; }

    public double? BftoEdge { get; set; }

    public string? DoveLockBoltMaterial { get; set; }

    public string? CclampId { get; set; }

    public string? CclampLabel { get; set; }

    public bool? StandardCclamp { get; set; }

    public bool? IsPart { get; set; }

    public string? Device { get; set; }

    public string? CoilSuppShape { get; set; }

    public double? CoilSuppHeight { get; set; }

    public double? CoilSuppWidth { get; set; }

    public double? CoilSuppGuage { get; set; }

    public string? CoreFeetInsMaterial { get; set; }

    public float? CoreFeetInsGauge { get; set; }

    public float? CoreFeetInsWidth { get; set; }

    public float? CoreFeetInsLength { get; set; }

    public string? CutOutSuppMaterial { get; set; }

    public float? CutOutSuppDia { get; set; }

    public float? CutOutSuppWidth { get; set; }

    public float? CutOutSuppHeight { get; set; }

    public float? CutOutSuppGauge { get; set; }
}
