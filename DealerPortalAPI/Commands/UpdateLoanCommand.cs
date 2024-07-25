using MediatR;

namespace DealerPortalAPI.Commands
{
    public class UpdateLoanCommand : IRequest<bool>
    {
        public int LoanId { get; set; }
        public int VendorId { get; set; }
        public int ApplicantId { get; set; }
        public decimal LoanAmount { get; set; }
        public DateTime LoanDate { get; set; }
        public string Status { get; set; } = null!;
    }

}
