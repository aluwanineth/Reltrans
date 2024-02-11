using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignTestGroupDetail
{
    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public int? GroupId { get; set; }

    public string? WindingName { get; set; }

    public string? PriSec { get; set; }

    public int? WindingNo { get; set; }
}
