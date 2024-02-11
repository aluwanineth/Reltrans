using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempBobbins
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }

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

    public bool? StandardBobbin { get; set; }

    public string? BobbinMaterial { get; set; }

    public bool? IsPart { get; set; }

    public string? Device { get; set; }
}
