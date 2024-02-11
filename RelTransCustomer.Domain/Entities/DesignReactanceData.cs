using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignReactanceData
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public float? NominalVa { get; set; }

    public int? CoreShape { get; set; }

    public float? Vt { get; set; }

    public float? CoreOd1 { get; set; }

    public float? CoreOd2 { get; set; }

    public int? C1Vector { get; set; }

    public float? C1VoltsPhase { get; set; }

    public float? C1VoltsLine { get; set; }

    public float? C1AmpsPhase { get; set; }

    public float? C1AmpsLine { get; set; }

    public float? C1TurnsNom { get; set; }

    public float? C1Radial { get; set; }

    public float? C1Mlt { get; set; }

    public float? C1Id1 { get; set; }

    public float? C1Od1 { get; set; }

    public float? C1Id2 { get; set; }

    public float? C1Od2 { get; set; }

    public float? C1Length { get; set; }

    public float? HlRadial { get; set; }

    public float? HlMlt { get; set; }

    public float? HlId1 { get; set; }

    public float? HlOd1 { get; set; }

    public float? HlId2 { get; set; }

    public float? HlOd2 { get; set; }

    public int? C2Vector { get; set; }

    public float? C2VoltsPhase { get; set; }

    public float? C2VoltsLine { get; set; }

    public float? C2AmpsPhase { get; set; }

    public float? C2AmpsLine { get; set; }

    public float? C2TurnsNom { get; set; }

    public float? C2Radial { get; set; }

    public float? C2Mlt { get; set; }

    public float? C2Id1 { get; set; }

    public float? C2Od1 { get; set; }

    public float? C2Id2 { get; set; }

    public float? C2Od2 { get; set; }

    public float? C2Length { get; set; }
}
