using DealerPortalAPI.Commands;
using DealerPortalAPI.Data;
using MediatR;

namespace DealerPortalAPI.Handlers.ComandHandlers
{
    public class UpdateLoanCommandHandler : IRequestHandler <UpdateLoanCommand , bool>
    {
        private readonly DealerPortalContext _context;

        public UpdateLoanCommandHandler(DealerPortalContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _context.Loans.FindAsync(request.LoanId);
            if (loan == null) return false;

            loan.VendorId = request.VendorId;
            loan.ApplicantId = request.ApplicantId;
            loan.LoanAmount = request.LoanAmount;
            loan.LoanDate = request.LoanDate;
            loan.Status = request.Status;

            _context.Loans.Update(loan);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
