using Microsoft.AspNetCore.Mvc;
using tech_interview_api.Application.Loans.Commands;
using tech_interview_api.Application.Loans.Models;

namespace tech_interview_api.Api;

[ApiController]
[Route("[controller]")]
public class LoanController
{
    private readonly GetLoansCommandHandler getLoansCommandHandler;
    public LoanController(GetLoansCommandHandler getLoansCommandHandler) => this.getLoansCommandHandler = getLoansCommandHandler;

    [HttpGet]
    public async Task<List<LoanDto>> Get() => await getLoansCommandHandler.Handle(new GetLoansCommand());
}