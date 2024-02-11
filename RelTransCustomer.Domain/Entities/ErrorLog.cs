using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class ErrorLog
{
    public int RecId { get; set; }

    public string? User { get; set; }

    public DateTime? Date { get; set; }

    public string? SenderClass { get; set; }

    public string? ErrorClass { get; set; }

    public string? ErrorMsg { get; set; }
}
