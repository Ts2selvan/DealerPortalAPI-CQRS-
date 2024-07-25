using System;
using System.Collections.Generic;

namespace DealerPortalAPI.Models;

public partial class Applicant
{
    public int ApplicantId { get; set; }

    public string ApplicantName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
