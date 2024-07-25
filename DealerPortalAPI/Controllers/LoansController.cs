using DealerPortalAPI.Commands;
using DealerPortalAPI.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DealerPortalAPI.Controllers
   
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LoansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var loans = await _mediator.Send(new GetLoansQuery());
            return Ok(loans);
        }

        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] CreateLoanCommand command)
        //{
        //    var loanId = await _mediator.Send(command);
        //    return CreatedAtAction(nameof(GetById), new { id = loanId }, command.Loan);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var loan = await _mediator.Send(new GetLoanByIdQuery { LoanId = id });
            if (loan == null)
                return NotFound();
            return Ok(loan);
        }
    }
}
