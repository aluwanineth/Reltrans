using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignJobHistory
{
    public int Id { get; set; }

    public string Specno { get; set; } = null!;

    public int? Revno { get; set; }

    public string Jobno { get; set; } = null!;

    public string Customer { get; set; } = null!;

    public decimal Envcosting { get; set; }

    public DateTime Publishdate { get; set; }

    public string Publishedby { get; set; } = null!;
}
