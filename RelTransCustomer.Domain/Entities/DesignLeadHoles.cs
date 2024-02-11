using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignLeadHoles
{
    public int Sqlid { get; set; }

    public int LeadId { get; set; }

    public int? HoleNo { get; set; }

    public float? LengthOffset { get; set; }

    public float? WidthOffset { get; set; }

    public float? Diameter { get; set; }
}
