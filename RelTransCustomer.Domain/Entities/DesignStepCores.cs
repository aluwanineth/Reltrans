using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignStepCores
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public int? StepNo { get; set; }

    public double? LegWidth { get; set; }

    public double? LegStack { get; set; }

    public int? Phases { get; set; }

    public double? Va { get; set; }

    public string? InsClass { get; set; }

    public double? VoltsClass { get; set; }
}
