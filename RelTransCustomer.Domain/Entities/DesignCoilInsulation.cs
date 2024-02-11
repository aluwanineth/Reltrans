using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignCoilInsulation
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int RecId { get; set; }

    public string Location { get; set; } = null!;

    public string Label { get; set; } = null!;

    public int? Sort { get; set; }

    public string? Material { get; set; }

    public float? CoilLength { get; set; }

    public int? CoilsPerLeg { get; set; }

    public int? LengthRef { get; set; }

    public int? Wraps { get; set; }

    public int? Sides { get; set; }

    public float? Pitch { get; set; }

    public float? Length { get; set; }

    public int? QtyPerCoil { get; set; }

    public float? Gauge { get; set; }

    public string? Type { get; set; }
}
