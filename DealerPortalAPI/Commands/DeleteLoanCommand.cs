using MediatR;

namespace DealerPortalAPI.Commands
{
    public class DeleteLoanCommand : IRequest<bool>
    {
        public int LoanId { get; set; }
    }
}
