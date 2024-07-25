using DealerPortalAPI.Commands;
using DealerPortalAPI.Data;
using DealerPortalAPI.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DealerPortalAPI.Handlers.ComandHandlers
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, bool>
    {
        private readonly DealerPortalContext _context;

        public CreateLoanCommandHandler(DealerPortalContext context)
        {
            _context = context;

         
        }

        public async Task<bool> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Loan
            {
                VendorId = request.VendorId,
                ApplicantId = request.ApplicantId,
                LoanAmount = request.LoanAmount,
                LoanDate = request.LoanDate,
                Status = request.Status
            };

            _context.Loans.Add(loan);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
