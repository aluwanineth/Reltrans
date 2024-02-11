using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignGa
{
    public int Recid { get; set; }

    public string? JobNo { get; set; }

    public string? AccNo { get; set; }

    public string? SpecNo { get; set; }

    public int? RevNo { get; set; }

    public string? DocName { get; set; }

    public string? Status { get; set; }

    public string? FileLocation { get; set; }
}
