using System;
using System.Collections.Generic;

namespace Dex.Entities;

public partial class RtenquiryDesign
{
    public int? DesignId { get; set; }

    public DateTime? Moddate { get; set; }

    public string SpecNo { get; set; } = null!;

    public string? Description { get; set; }

    public int RevNo { get; set; }

    public string? RevNotes { get; set; }

    public double? TotalVa { get; set; }

    public int? Phases { get; set; }

    public string? Cooling { get; set; }

    public double? Frequency { get; set; }

    public string? Device { get; set; }

    public string? WindingMaterial { get; set; }

    public double? Primary { get; set; }

    public double? Secondary { get; set; }

    public string? InsulationClass { get; set; }

    public string? SpecVector { get; set; }

    public string? ImpedanceType { get; set; }

    public string? SpecBase { get; set; }

    public string? SpecColour { get; set; }

    public string? OilType { get; set; }

    public string? SpecTaps { get; set; }

    public string? Altitude { get; set; }

    public string? IndoorOutDoor { get; set; }

    public bool? TapSwitchEnable { get; set; }

    public bool? OilGuageEnable { get; set; }

    public bool? BucholtzEnable { get; set; }

    public bool? ThermPocketEnable { get; set; }

    public bool? FillerEnable { get; set; }

    public bool? DrainEnable { get; set; }

    public bool? OilThermEnable { get; set; }

    public bool? BreatherEnable { get; set; }

    public bool? Prvenable { get; set; }

    public bool? WheelsEnable { get; set; }

    public bool? ExpVentEnable { get; set; }

    public bool? Pmbenable { get; set; }

    public bool? JackingPadsEnable { get; set; }

    public bool? ConservatorEnable { get; set; }

    public bool? NerEnable { get; set; }

    public bool? NermEnable { get; set; }

    public bool? FitRatingplate { get; set; }

    public decimal? Costing { get; set; }

    public string? Category { get; set; }

    public bool? QuoteDesign { get; set; }

    public string? Enclosure { get; set; }

    public int? LastQuoteId { get; set; }

    public int? LastOrderId { get; set; }

    public int? QuoteId { get; set; }

    public DateTime? QuoteDate { get; set; }

    public decimal? QuotePrice { get; set; }

    public string? QuoteAccNo { get; set; }

    public int? OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? OrderPrice { get; set; }

    public string? OrderAccNo { get; set; }

    public DateTime? LastQuote { get; set; }

    public decimal? LastQuotePrice { get; set; }

    public DateTime? LastOrder { get; set; }

    public decimal? LastOrderPrice { get; set; }

    public string? QuoteCustomer { get; set; }

    public string? OrderCustomer { get; set; }
}
