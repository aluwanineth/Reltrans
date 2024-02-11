using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class Catalog
{
    public int RecId { get; set; }

    public string? FileName { get; set; }

    public string? Path { get; set; }

    public string? Iso9001 { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Authorised { get; set; }

    public string? Revision { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? DocTitle { get; set; }

    public int? StampX { get; set; }

    public int? StampY { get; set; }

    public DateTime? ModDate { get; set; }

    public string? Future1 { get; set; }

    public string? Future2 { get; set; }

    public string? Future3 { get; set; }

    public int? AnglePdf { get; set; }

    public int? AngleStamp { get; set; }

    public string? JobNo { get; set; }

    public string? What { get; set; }
}
