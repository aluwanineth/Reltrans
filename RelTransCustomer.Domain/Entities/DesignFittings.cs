using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignFittings
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string FittingType { get; set; } = null!;

    public int FittingId { get; set; }

    public string? FittingMaterial { get; set; }
}
