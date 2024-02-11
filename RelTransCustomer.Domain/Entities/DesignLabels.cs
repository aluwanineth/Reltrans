using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignLabels
{
    public string SpecNo { get; set; } = null!;

    public int? RevNo { get; set; }

    public string PriSec { get; set; } = null!;

    public int LabelNo { get; set; }

    public string? LabelMaterial { get; set; }

    public int? LabelQty { get; set; }
}
