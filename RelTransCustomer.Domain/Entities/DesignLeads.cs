using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignLeads
{
    public int Sqlid { get; set; }

    public int TapId { get; set; }

    public string? Description { get; set; }

    public string? Material { get; set; }

    public float? TotalLength { get; set; }

    public float? BottomExtend { get; set; }
}
