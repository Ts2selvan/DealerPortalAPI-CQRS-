using System;
using System.Collections.Generic;

namespace DealerPortalAPI.Models;

public partial class Vendor
{
    public int VendorId { get; set; }

    public string VendorName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int? Year { get; set; }

    public string? Model { get; set; }

    public string? Make { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
