﻿using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignTanks
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public int? TankType { get; set; }

    public string? TankTypeName { get; set; }

    public string? Construction { get; set; }

    public double? TankRise { get; set; }

    public double? ExtraWatts { get; set; }

    public double? TankWidth { get; set; }

    public double? TankDepth { get; set; }

    public double? TankHeight { get; set; }

    public string? TankLidMaterial { get; set; }

    public double? TankLidThick { get; set; }

    public string? TankWallMaterial { get; set; }

    public double? TankWallThick { get; set; }

    public double? TankBaseThick { get; set; }

    public string? TankBaseMaterial { get; set; }

    public double? TankCboxThick { get; set; }

    public string? TankBaseType { get; set; }

    public string? TankSlotsType { get; set; }

    public double? TankRim { get; set; }

    public string? TankRimMaterial { get; set; }

    public int? RadBankCount { get; set; }

    public int? CboxCount { get; set; }

    public double? Tftop { get; set; }

    public double? Tfheight { get; set; }

    public double? Tfbottom { get; set; }

    public double? Tfguage { get; set; }

    public double? Tfholes { get; set; }

    public double? TfslotWidth { get; set; }

    public double? TfslotHeight { get; set; }

    public int? RibNo { get; set; }

    public int? RibPos { get; set; }

    public string? RibPosName { get; set; }

    public double? RibQty { get; set; }

    public double? RibWidth { get; set; }

    public double? RibGuage { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

    public string? TankSkidsMaterial { get; set; }

    public string? TankSkidsShape { get; set; }

    public bool? TankSkidsSlots { get; set; }

    public double? TankSkidsLength { get; set; }

    public bool? TankSkidsLengthLock { get; set; }

    public double? TankRaisedGauge { get; set; }

    public double? TankRaisedLength { get; set; }

    public double? TankRaisedHeight { get; set; }

    public double? TankRaisedTop { get; set; }

    public double? TankRaisedBottom { get; set; }

    public bool? TankRaisedSlots { get; set; }

    public double? TankRaisedSlotsDia { get; set; }

    public double? TankRaisedSlotsWidth { get; set; }

    public double? TankRaisedSlotsHeight { get; set; }

    public string? SelectedTankBase { get; set; }

    public string? VentBoxType { get; set; }

    public double? VentBoxStuds { get; set; }

    public string? VentboxBasePaint { get; set; }

    public float? VentBoxBasePaintThickness { get; set; }

    public bool? BaseFlat { get; set; }

    public bool? BasePlatform { get; set; }

    public bool? BaseSkids { get; set; }

    public bool? BaseRaised { get; set; }

    public string? PaintMaterial { get; set; }

    public string? PaintType { get; set; }

    public float? PaintThickness { get; set; }

    public string? PrimerMaterial { get; set; }

    public string? PrimerType { get; set; }

    public float? PrimerThickness { get; set; }

    public string? ThinnersMaterial { get; set; }

    public string? PrimerThinnersMaterial { get; set; }

    public float? ThinnersLiters { get; set; }

    public float? PrimerThinnersLiters { get; set; }

    public string? PaintClass { get; set; }

    public string? TankRimCorkMaterial { get; set; }

    public float? TankRimCorkGauge { get; set; }

    public float? TankRimCorkWidth { get; set; }

    public float? TankRimCorkLength { get; set; }

    public string? TankBracketMaterial { get; set; }

    public float? TankBracketTopWidth { get; set; }

    public float? TankBracketBottomWidth { get; set; }

    public float? TankBracketHeight { get; set; }

    public float? TankBracketThickness { get; set; }

    public float? TankBracketLength { get; set; }

    public string? TankBracketProfile { get; set; }

    public int? TankBracketQty { get; set; }

    public string? CrossBraceMaterial { get; set; }

    public string? CrossBraceProfile { get; set; }

    public float? CrossBraceTopWidth { get; set; }

    public float? CrossBraceBottomWidth { get; set; }

    public float? CrossBraceHeight { get; set; }

    public float? CrossBraceLength { get; set; }

    public int? CrossBraceQty { get; set; }

    public float? CrossBraceThickness { get; set; }
}
