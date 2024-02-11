using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempMain
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string? DesignString { get; set; }

    public int? Phases { get; set; }

    public double? TotalVa { get; set; }

    public double? Henries { get; set; }

    public decimal? Cost { get; set; }

    public double? Markup { get; set; }

    public decimal? Sales { get; set; }

    public DateTime? ModDate { get; set; }

    public int? Lock { get; set; }

    public int? CatNo { get; set; }

    public string? DexVersion { get; set; }

    public string? SaveVersion { get; set; }

    public string? Device { get; set; }

    public string? Cooling { get; set; }

    public double? Frequency { get; set; }

    public int? CoreType { get; set; }

    public string? CoreGrade { get; set; }

    public string? CoreName { get; set; }

    public double? FeCsa { get; set; }

    public double? Flux { get; set; }

    public double? VoltsPerTurn { get; set; }

    public double? CoreMass { get; set; }

    public double? WperKg { get; set; }

    public double? CoreLoss { get; set; }

    public double? CoreLegWidth { get; set; }

    public double? WoodWidth { get; set; }

    public double? CoilWidth { get; set; }

    public double? CoreLegDepth { get; set; }

    public double? WoodDepth { get; set; }

    public double? CoilDepth { get; set; }

    public double? CoreLength { get; set; }

    public double? PhaseCentres { get; set; }

    public double? CoilGap { get; set; }

    public double? CoreDivide { get; set; }

    public double? SeriesPar { get; set; }

    public double? Hlduct { get; set; }

    public double? HlductType { get; set; }

    public double? FormerGuage { get; set; }

    public double? HlinsGuage { get; set; }

    public double? Hlinsulation { get; set; }

    public double? FeDiameter { get; set; }

    public double? Steps { get; set; }

    public double? Chop { get; set; }

    public double? Odpreset { get; set; }

    public string? Standard { get; set; }

    public int? PriWindings { get; set; }

    public int? SecWindings { get; set; }

    public double? SecEddies { get; set; }

    public double? Lveddies { get; set; }

    public double? DoveHeight { get; set; }

    public double? DoveLength { get; set; }

    public double? DoveWidth { get; set; }

    public int? DoveQty { get; set; }

    public string? DoveShape { get; set; }

    public double? DoveInnerWidth { get; set; }

    public double? DoveOuterWidth { get; set; }

    public double? GlueBoardGuage { get; set; }

    public double? CoilRingGuage { get; set; }

    public double? CoilPacking { get; set; }

    public string? CoreFeetSpec { get; set; }

    public double? CoreFeetHeight { get; set; }

    public double? CoreFeetWidth { get; set; }

    public double? CoreFeetGuage { get; set; }

    public double? CoreFeetLength { get; set; }

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

    public string? Pdes { get; set; }

    public string? SpecInput { get; set; }

    public string? SpecOutput { get; set; }

    public string? SpecTaps { get; set; }

    public string? SpecBase { get; set; }

    public string? SpecColour { get; set; }

    public string? SpecVector { get; set; }

    public bool? FitTapswitch { get; set; }

    public bool? FitBucholtz { get; set; }

    public bool? FitThermometer { get; set; }

    public bool? FitJackingPads { get; set; }

    public bool? FitWheels { get; set; }

    public bool? FitConservator { get; set; }

    public bool? FitRatingplate { get; set; }

    public bool? FitBreather { get; set; }

    public bool? FitOilguage { get; set; }

    public bool? FitExpVent { get; set; }

    public bool? FitLiftingLugs { get; set; }

    public bool? FitPressRelValve { get; set; }

    public bool? FitWindTherm { get; set; }

    public bool? FitNer { get; set; }

    public bool? FitNerm { get; set; }

    public string? SpecSpecNo { get; set; }

    public string? SpecDesc { get; set; }

    public string? SpecProjectDesc { get; set; }

    public string? DovetailMaterial { get; set; }

    public string? GlueBoardMaterial { get; set; }

    public string? CoilRingMaterial { get; set; }

    public string? HlspacerMaterial { get; set; }

    public string? HlpaperMaterial { get; set; }

    public string? TboardMaterial { get; set; }

    public string? PriBushingMaterial { get; set; }

    public string? SecBushingMaterial { get; set; }

    public string? CoreClampMaterial { get; set; }

    public string? StiffenerMaterial { get; set; }

    public string? CoilSuppMaterial { get; set; }

    public string? CoreFeetMaterial { get; set; }

    public string? VerTieRodMaterial { get; set; }

    public string? HorTieRodMaterial { get; set; }

    public double? TboardWidth { get; set; }

    public double? TboardDepth { get; set; }

    public double? TboardThickness { get; set; }

    public string? TboardPos { get; set; }

    public double? Vertie1Length { get; set; }

    public double? Hortie1Length { get; set; }

    public double? HorTie2Length { get; set; }

    public double? FrameStiffenerLength { get; set; }

    public double? CoilSupportLength { get; set; }

    public string? CoilSupportSinDoub { get; set; }

    public int? LimbCount { get; set; }

    public string? LimbClamps { get; set; }

    public string? InsulationClass { get; set; }

    public double? PriBushingClearance { get; set; }

    public double? SecBushingClearance { get; set; }

    public double? FlangeCentreDia { get; set; }

    public double? FlangeDia { get; set; }

    public double? FlangeCutout1 { get; set; }

    public double? FlangeCutout2 { get; set; }

    public double? FlangeCutout3 { get; set; }

    public double? FlangeCutout4 { get; set; }

    public string? PhaseBarrierMaterial { get; set; }

    public double? PhaseBarrierWidth { get; set; }

    public double? PhaseBarrierHeight { get; set; }

    public double? PhaseBarrierGuage { get; set; }

    public int? PhaseBarrierQty { get; set; }

    public double? TswitchHoleX { get; set; }

    public double? TswitchHolY { get; set; }

    public double? TswitchHoleCentre { get; set; }

    public double? TswitchHoleDia { get; set; }

    public double? DoveLockPosDia { get; set; }

    public double? DoveLockHoleDia { get; set; }

    public double? CutSupportX { get; set; }

    public double? CutSupportY { get; set; }

    public double? CutSupportDia { get; set; }

    public string? CutSupportType { get; set; }

    public double? MountHoleX { get; set; }

    public double? MountHoleY { get; set; }

    public double? MountHoleDia { get; set; }

    public double? LiftHoleToEdge { get; set; }

    public double? LiftHoleToTop { get; set; }

    public double? LiftHoleDia { get; set; }

    public double? BftoEdge { get; set; }

    public string? DoveLockBoltMaterial { get; set; }

    public string? TankRimMaterial { get; set; }

    public double? RimBoltPitch { get; set; }

    public int? RimBoltQty { get; set; }

    public string? ConsRimMaterial { get; set; }

    public double? ConsRimPitch { get; set; }

    public int? ConsRimQty { get; set; }

    public string? TapeMaterial { get; set; }

    public double? TapeQty { get; set; }

    public string? TswitchBossPos { get; set; }

    public string? TswitchBossMaterial { get; set; }

    public double? TswitchBossX { get; set; }

    public double? TswitchBossY { get; set; }

    public double? TswitchBossDia { get; set; }

    public string? OilGuagePos { get; set; }

    public string? OilGuageMaterial { get; set; }

    public double? OilGuageX { get; set; }

    public double? OilGuageY { get; set; }

    public double? OilGuageDia { get; set; }

    public string? BreatherPos { get; set; }

    public string? BreatherMaterial { get; set; }

    public double? BreatherX { get; set; }

    public double? BreatherY { get; set; }

    public double? BreatherDia { get; set; }

    public string? FillerPipePos { get; set; }

    public string? FillerPipeMaterial { get; set; }

    public double? FillerPipeX { get; set; }

    public double? FillerPipeY { get; set; }

    public double? FillerPipeDia { get; set; }

    public string? DrainValvePos { get; set; }

    public string? DrainValveMaterial { get; set; }

    public double? DrainValveX { get; set; }

    public double? DrainValveY { get; set; }

    public double? DrainValveDia { get; set; }

    public string? OilThermPos { get; set; }

    public string? OilThermMaterial { get; set; }

    public double? OilThermX { get; set; }

    public double? OilThermY { get; set; }

    public double? OilThermDia { get; set; }

    public string? TankrimType { get; set; }

    public string? MarshalBoxPos { get; set; }

    public string? MarshalBoxMaterial { get; set; }

    public double? MarshalBoxX { get; set; }

    public double? MarshalBoxY { get; set; }

    public double? MarshalBoxWidth { get; set; }

    public double? MarshalBoxDepth { get; set; }

    public double? MarshalBoxHeight { get; set; }

    public double? YokeWidth { get; set; }

    public double? FithLegWidth { get; set; }

    public string? RplatePos { get; set; }

    public string? RplateMaterial { get; set; }

    public double? Rpx { get; set; }

    public double? Rpy { get; set; }

    public double? Rpwidth { get; set; }

    public double? Rpdepth { get; set; }

    public double? Rpheight { get; set; }

    public string? BucholtzMaterial { get; set; }

    public double? BucholtzX { get; set; }

    public double? BucholtzY { get; set; }

    public double? BucholtzLength { get; set; }

    public double? BucholtzHeight { get; set; }

    public double? BucholtzAngle { get; set; }

    public string? LiftLugType { get; set; }

    public int? LiftLugQty { get; set; }

    public float? LiftLugGauge { get; set; }

    public string? LiftLugBtype { get; set; }

    public int? LiftLugBqty { get; set; }

    public float? LiftLugBgauge { get; set; }

    public string? OilType { get; set; }

    public double? OvalWidth { get; set; }

    public double? OvalStack { get; set; }

    public double? OvalCutAway { get; set; }

    public string? Term1Material { get; set; }

    public int? Term1Qty { get; set; }

    public string? Term2Material { get; set; }

    public int? Term2Qty { get; set; }

    public string? Term3Material { get; set; }

    public int? Term3Qty { get; set; }

    public string? Term4Material { get; set; }

    public int? Term4Qty { get; set; }

    public bool? IsPart { get; set; }

    public bool? StandardCore { get; set; }

    public bool? StandardCclamp { get; set; }

    public bool? StandardBobbin { get; set; }

    public string? ChildCore { get; set; }

    public string? ChildBobbin { get; set; }

    public string? ChildCclamp { get; set; }

    public string? CclampId { get; set; }

    public string? CclampLabel { get; set; }

    public string? PartType { get; set; }

    public string? ParentRef { get; set; }

    public double? VoltsClass { get; set; }

    public string? WedgeMaterial { get; set; }

    public string? CoreInsMaterial { get; set; }

    public double? CoilWedgeWidth { get; set; }

    public double? CoilWedgeLength { get; set; }

    public double? CoilWedgeGuage { get; set; }

    public double? CoreInsGuage { get; set; }

    public string? EndWrapMaterial { get; set; }

    public int? EndWrapWraps { get; set; }

    public double? EndWrapGuage { get; set; }

    public string? FinPaperMaterial { get; set; }

    public int? FinPaperWraps { get; set; }

    public double? FinPaperGuage { get; set; }

    public string? FinTapeMaterial { get; set; }

    public int? FinTapeWraps { get; set; }

    public double? FinTapeGuage { get; set; }

    public double? FinTapeWidth { get; set; }

    public double? FinTapeLength { get; set; }

    public string? WindingSpecNotes { get; set; }

    public string? CclampDrawingPdf { get; set; }

    public string? AssemblySpecPdf { get; set; }

    public string? TbdrawingPdf { get; set; }

    public string? TblabelPdf { get; set; }

    public string? Testdatapdf { get; set; }

    public string? ProductSpecPdf { get; set; }

    public string? ReleaseListPdf { get; set; }

    public string? PackingListPdf { get; set; }

    public string? GadrawingPdf { get; set; }

    public string? CclampAssyDrawingPdf { get; set; }

    public string? TankAssyPdf { get; set; }

    public string? TankLabelsPdf { get; set; }

    public string? RadAssyPdf { get; set; }

    public string? MainTankCorkMaterial { get; set; }

    public string? ConsCorkMaterial { get; set; }

    public float? DexCostingMarkUp { get; set; }

    public string? PriSideLab1 { get; set; }

    public int? PriSideLab1Qty { get; set; }

    public string? PriSideLab2 { get; set; }

    public int? PriSideLab2Qty { get; set; }

    public string? PriSideLab3 { get; set; }

    public int? PriSideLab3Qty { get; set; }

    public string? PriSideLab4 { get; set; }

    public int? PriSideLab4Qty { get; set; }

    public string? PriSideLab5 { get; set; }

    public int? PriSideLab5Qty { get; set; }

    public string? PriSideLab6 { get; set; }

    public int? PriSideLab6Qty { get; set; }

    public string? SecSideLab1 { get; set; }

    public int? SecSideLab1Qty { get; set; }

    public string? SecSideLab2 { get; set; }

    public int? SecSideLab2Qty { get; set; }

    public string? SecSideLab3 { get; set; }

    public int? SecSideLab3Qty { get; set; }

    public string? SecSideLab4 { get; set; }

    public int? SecSideLab4Qty { get; set; }

    public string? SecSideLab5 { get; set; }

    public int? SecSideLab5Qty { get; set; }

    public string? SecSideLab6 { get; set; }

    public int? SecSideLab6Qty { get; set; }

    public string? ImportedSpecNo { get; set; }

    public DateTime? ImportedDate { get; set; }

    public bool? PriCboxEnable { get; set; }

    public bool? TmpPriCboxEnable { get; set; }

    public bool? PriPocketEnable { get; set; }

    public bool? PriOpenEnable { get; set; }

    public bool? TmpPriPocketEnable { get; set; }

    public bool? SecCboxEnable { get; set; }

    public bool? TmpSecCboxEnable { get; set; }

    public bool? SecPocketEnable { get; set; }

    public bool? SecOpenEnable { get; set; }

    public bool? TmpSecPocketEnable { get; set; }

    public bool? TankSkidsEnable { get; set; }

    public bool? TmpTankSkidsEnable { get; set; }

    public bool? TapSwitchEnable { get; set; }

    public bool? TmpTapSwitchEnable { get; set; }

    public bool? OilGuageEnable { get; set; }

    public bool? TmpOilGuageEnable { get; set; }

    public bool? FillerEnable { get; set; }

    public bool? TmpFillerEnable { get; set; }

    public bool? DrainEnable { get; set; }

    public bool? TmpDrainEnable { get; set; }

    public bool? OilThermEnable { get; set; }

    public bool? TmpOilThermEnable { get; set; }

    public bool? BreatherEnable { get; set; }

    public bool? TmpBreatherEnable { get; set; }

    public bool? BucholtzEnable { get; set; }

    public bool? TmpBucholtzEnable { get; set; }

    public bool? OilEnable { get; set; }

    public bool? ThermPocketEnable { get; set; }

    public bool? Wtienable { get; set; }

    public bool? Prvenable { get; set; }

    public bool? ExpVentEnable { get; set; }

    public bool? FlatBaseEnable { get; set; }

    public bool? RaisedBaseEnable { get; set; }

    public bool? WheelsEnable { get; set; }

    public bool? Pmbenable { get; set; }

    public bool? LiftingLugsEnable { get; set; }

    public bool? JackingPadsEnable { get; set; }

    public bool? RadiatorsEnable { get; set; }

    public bool? ConservatorEnable { get; set; }

    public bool? NerEnable { get; set; }

    public bool? NermEnable { get; set; }

    public string? PriCboxMaterial { get; set; }

    public string? SecCboxMaterial { get; set; }

    public string? PriPocketMaterial { get; set; }

    public string? SecPocketMaterial { get; set; }

    public string? PriOpenMaterial { get; set; }

    public string? SecOpenMaterial { get; set; }

    public int? RangeId { get; set; }

    public int? RangeItemId { get; set; }

    public bool? InputLock { get; set; }

    public bool? OutputLock { get; set; }

    public bool? Kvalock { get; set; }

    public string? Varange { get; set; }

    public string? Prvmaterial { get; set; }

    public string? Prvposition { get; set; }

    public float? Prvx { get; set; }

    public float? Prvy { get; set; }

    public float? Prvdia { get; set; }

    public string? Prvmplate { get; set; }

    public bool? ReliefValveEnabled { get; set; }

    public string? DesignNotes { get; set; }

    public string? WheelsMaterial { get; set; }

    public float? WheelsQty { get; set; }

    public float? WheelsOd { get; set; }

    public float? WheelsId { get; set; }

    public float? WheelsGauge { get; set; }

    public string? AxleMaterial { get; set; }

    public float? AxleGauge { get; set; }

    public float? AxleLength { get; set; }

    public bool? WheelsEnabled { get; set; }

    public double? OverallWidth { get; set; }

    public double? OverallDepth { get; set; }

    public double? OverallHeight { get; set; }

    public double? OverallMass { get; set; }

    public double? OilNettLiters { get; set; }

    public string? Mvbil { get; set; }

    public string? Lvbil { get; set; }

    public bool? Active { get; set; }

    public string? ThermPocketPos { get; set; }

    public string? ThermPocketType { get; set; }

    public double? ThermPocketDia { get; set; }

    public double? ThermPocketX { get; set; }

    public double? ThermPocketY { get; set; }

    public string? JackingPadType { get; set; }

    public int? JackingPadQty { get; set; }

    public double? JackingPadGauge { get; set; }

    public string? PoleMountBracketType { get; set; }

    public string? CoreWindingBracketType { get; set; }

    public string? CableRailType { get; set; }

    public double? CableRailGauge { get; set; }

    public float? CableRailQty { get; set; }

    public string? CableRailBtype { get; set; }

    public float? CableRailBgauge { get; set; }

    public float? CableRailBqty { get; set; }

    public string? RatingPlateBracket { get; set; }

    public string? MarshallBoxBracket { get; set; }

    public double? BucholtzCox { get; set; }

    public double? BucholtzCoy { get; set; }

    public double? BucholtzCodia { get; set; }

    public bool? QuoteDesign { get; set; }

    public bool? SkidBaseEnable { get; set; }

    public string? WindingMaterial { get; set; }

    public string? DrainValveGaurdType { get; set; }

    public int? DrainValveGaurdQty { get; set; }

    public float? DrainValveGaurdGauge { get; set; }

    public string? LeadSupportType { get; set; }

    public int? LeadSupportQty { get; set; }

    public float? LeadSupportGauge { get; set; }

    public string? LimitSwitchType { get; set; }

    public int? LimitSwitchQty { get; set; }

    public float? LimitSwitchGauge { get; set; }

    public string? AuxWiringType { get; set; }

    public string? Nertype { get; set; }

    public int? Nerqty { get; set; }

    public string? Nermtype { get; set; }

    public int? Nermqty { get; set; }

    public bool? CoverEnabled { get; set; }

    public string? CoverType { get; set; }

    public bool? WindingsEnabled { get; set; }

    public string? IndoorOutDoor { get; set; }

    public bool? ImpedanceEnabled { get; set; }

    public string? ImpedanceType { get; set; }

    public string? Altitude { get; set; }

    public bool? MarshallBoxEnabled { get; set; }
}
