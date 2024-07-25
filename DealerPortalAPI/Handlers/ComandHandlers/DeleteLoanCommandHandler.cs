using DealerPortalAPI.Commands;
using DealerPortalAPI.Data;
using MediatR;

namespace DealerPortalAPI.Handlers.ComandHandlers
{
    public class DeleteLoanCommandHandler : IRequestHandler<DeleteLoanCommand, bool>
    {
        private readonly DealerPortalContext _context;

        public DeleteLoanCommandHandler(DealerPortalContext context)
        {
            _context = context;
        }
        public async Task<bool> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _context.Loans.FindAsync(request.LoanId);
            if (loan == null) return false;

            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
