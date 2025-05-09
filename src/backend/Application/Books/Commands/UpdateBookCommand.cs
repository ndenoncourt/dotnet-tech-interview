using tech_interview_api.Application.Books.Models;
using tech_interview_api.Application.Common;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Books.Commands;

public class UpdateBookCommand : IRequest<BookDto>
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Author { get; set; }
}

public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, BookDto>
{
    private readonly ApplicationDbContext applicationDbContext;
    public UpdateBookCommandHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    public async Task<BookDto> Handle(UpdateBookCommand request)
    {
        Book? bookToUpdate = await applicationDbContext.Books.FindAsync(request.Id);

        bookToUpdate.Title = request.Title;
        bookToUpdate.Author = request.Author;
        applicationDbContext.Books.Update(bookToUpdate);
        await applicationDbContext.SaveChangesAsync();

        return new BookDto
        {
            Id = bookToUpdate.Id,
            Title = bookToUpdate.Title,
            Author = bookToUpdate.Author,
            IsAvailable = !applicationDbContext.Loans
                .Any(loan => loan.BookId == bookToUpdate.Id &&
                             loan.ReturnDate == null &&
                             loan.LoanDate <= DateTime.Now)
        };
    }
}