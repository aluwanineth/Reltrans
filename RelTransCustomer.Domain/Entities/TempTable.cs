using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class TempTable
{
    public int Id { get; set; }

    public string? Accessory { get; set; }

    public bool? Checked { get; set; }

    public decimal? TotalCost { get; set; }

    public decimal? BushingTotalCost { get; set; }

    public decimal? TotalAccCosting { get; set; }

    public decimal? Cst { get; set; }

    public int? RangeItemId { get; set; }

    public string SpecNo { get; set; } = null!;

    public int Revno { get; set; }

    public string? FlagName { get; set; }

    public bool? FlagValue { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public string? ProductId { get; set; }

    public string? BushingProdId { get; set; }

    public decimal? Costing { get; set; }

    public int? BushingQty { get; set; }

    public decimal BushingCosting { get; set; }
}
