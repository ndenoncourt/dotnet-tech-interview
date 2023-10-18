using Microsoft.EntityFrameworkCore;
using tech_interview_api.Application.Common;
using tech_interview_api.Application.Loans.Models;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Loans.Commands;

public class GetLoansCommand : IRequest<List<LoanDto>> { }

public class GetLoansCommandHandler : IRequestHandler<GetLoansCommand, List<LoanDto>>
{
    private readonly ApplicationDbContext applicationDbContext;
    public GetLoansCommandHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    public async Task<List<LoanDto>> Handle(GetLoansCommand request) =>
        await applicationDbContext.Loans.Select(loan => new LoanDto
        {
            Id = loan.Id,
            MemberId = loan.MemberId,
            BookId = loan.BookId,
            LoanDate = loan.LoanDate,
            ReturnDate = loan.ReturnDate
        }).ToListAsync();
}