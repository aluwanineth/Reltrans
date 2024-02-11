using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignParameters
{
    public int RecId { get; set; }

    public int? RangeId { get; set; }

    public string? ParamTable { get; set; }

    public string? ParamCaption { get; set; }

    public string? ParamValue { get; set; }
}
