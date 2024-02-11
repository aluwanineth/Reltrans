using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignDrawingScheduleDetail
{
    public int Id { get; set; }

    public int DrawingScheduleId { get; set; }

    public string ComponentName { get; set; } = null!;

    public string ComponentMaterial { get; set; } = null!;

    public string? ComponentStockCode { get; set; }

    public double ComponentGauge { get; set; }

    public int ComponentQty { get; set; }

    public string User { get; set; } = null!;

    public DateTime ModDate { get; set; }

    public bool? Completed { get; set; }

    public string? CompletedBy { get; set; }

    public DateTime? CompletedDate { get; set; }

    public bool? Display { get; set; }

    public double? Mass { get; set; }

    public bool? Lock { get; set; }
}
