using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignLeadBends
{
    public int Sqlid { get; set; }

    public int LeadId { get; set; }

    public int? BendNo { get; set; }

    public float? Offset { get; set; }

    public string? InOut { get; set; }

    public float? Angle { get; set; }
}
