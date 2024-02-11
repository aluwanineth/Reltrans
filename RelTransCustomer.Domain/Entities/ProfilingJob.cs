using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class ProfilingJob
{
    public string? JobNo { get; set; }

    public string? SpecNo { get; set; }

    public string? ProductName { get; set; }

    public string? Reference { get; set; }

    public string? Destination { get; set; }

    public int Id { get; set; }

    public int? DrawingScheduleId { get; set; }

    public string? ComponentName { get; set; }

    public string? ComponentMaterial { get; set; }

    public string? ComponentStockCode { get; set; }

    public double? ComponentGauge { get; set; }

    public int? ComponentQty { get; set; }

    public string? User { get; set; }

    public DateTime? ModDate { get; set; }

    public bool? Completed { get; set; }

    public string? CompletedBy { get; set; }

    public DateTime? CompletedDate { get; set; }

    public bool? Display { get; set; }

    public double? Mass { get; set; }

    public bool? Lock { get; set; }

    public DateTime? DelDate { get; set; }

    public float? OrderQty { get; set; }

    public float? ManuQty { get; set; }
}
