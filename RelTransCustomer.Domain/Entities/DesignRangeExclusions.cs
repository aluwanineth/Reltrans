using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignRangeExclusions
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int? RangeId { get; set; }

    public string? PropertyName { get; set; }

    public string? PropertyValue { get; set; }

    public string PropertyType { get; set; } = null!;

    public int? Side { get; set; }
}
