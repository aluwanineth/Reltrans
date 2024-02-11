using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignDrawingSchedule
{
    public int Id { get; set; }

    public string SpecNo { get; set; } = null!;

    public int RevNo { get; set; }

    public string JobNo { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string? Destination { get; set; }

    public bool? Lock { get; set; }
}
