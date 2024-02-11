using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignBomtree
{
    public int Id { get; set; }

    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string? JobNo { get; set; }

    public string? Node { get; set; }

    public int? NodeId { get; set; }

    public string? Parent { get; set; }

    public int? ParentId { get; set; }

    public string? Type { get; set; }

    public string? State { get; set; }

    public bool? NeedPart { get; set; }

    public int? Sort { get; set; }

    public bool? Enabled { get; set; }
}
