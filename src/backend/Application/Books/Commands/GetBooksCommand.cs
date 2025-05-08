using Microsoft.EntityFrameworkCore;
using tech_interview_api.Application.Books.Models;
using tech_interview_api.Application.Common;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Books.Commands;

public class GetBooksCommand : IRequest<List<BookDto>> { }

public class GetBooksCommandHandler : IRequestHandler<GetBooksCommand, List<BookDto>>
{
    private readonly ApplicationDbContext applicationDbContext;
    public GetBooksCommandHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    public Task<List<BookDto>> Handle(GetBooksCommand request) => applicationDbContext.Books.Select(book => new BookDto
    {
        Id = book.Id,
        Title = book.Title,
        Author = book.Author,
        IsAvailable = !applicationDbContext.Loans
            .Any(loan => loan.BookId == book.Id &&
                         loan.ReturnDate == null &&
                         loan.LoanDate <= DateTime.Now)
    }).OrderBy(book => book.Title).ToListAsync();
}