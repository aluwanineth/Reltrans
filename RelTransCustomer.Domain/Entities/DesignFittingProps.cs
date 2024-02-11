using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignFittingProps
{
    public string? PropName { get; set; }

    public string? PropValue { get; set; }

    public int FittingId { get; set; }

    public int FittingPropId { get; set; }
}
