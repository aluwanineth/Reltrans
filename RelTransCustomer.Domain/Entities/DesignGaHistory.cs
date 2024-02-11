using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class DesignGaHistory
{
    public int Recid { get; set; }

    public int? GaId { get; set; }

    public DateTime? EventDate { get; set; }

    public string? EventType { get; set; }

    public string? Notes { get; set; }

    public string? Sender { get; set; }

    public string? Recipient { get; set; }

    public string? Copied { get; set; }

    public string? Message { get; set; }
}
