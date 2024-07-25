using DealerPortalAPI.Data;
using DealerPortalAPI.Models;
using DealerPortalAPI.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DealerPortalAPI.Handlers.QueryHandlers
{
    public class GetLoanByIdQueryHandler : IRequestHandler<GetLoanByIdQuery, Loan>
    {
        private readonly DealerPortalContext _context;

        public GetLoanByIdQueryHandler(DealerPortalContext context)
        {
            _context = context;
        }

        public async Task<Loan> Handle(GetLoanByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Loans
                .Include(l => l.Applicant)
                .Include(l => l.Vendor)
                .FirstOrDefaultAsync(l => l.LoanId == request.LoanId, cancellationToken);
        }
    }
}
