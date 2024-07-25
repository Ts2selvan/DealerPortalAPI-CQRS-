using DealerPortalAPI.Models;
using MediatR;

namespace DealerPortalAPI.Queries
{
    public class GetLoanByIdQuery : IRequest<Loan>
    {
        public int LoanId { get; set; }
    }
}
