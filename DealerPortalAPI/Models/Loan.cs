using System;
using System.Collections.Generic;

namespace DealerPortalAPI.Models;

public partial class Loan
{
    public int LoanId { get; set; }

    public int VendorId { get; set; }

    public int ApplicantId { get; set; }

    public decimal LoanAmount { get; set; }

    public DateTime LoanDate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? LastUpdate { get; set; }

    public virtual Applicant Applicant { get; set; } = null!;

    public virtual Vendor Vendor { get; set; } = null!;
}
