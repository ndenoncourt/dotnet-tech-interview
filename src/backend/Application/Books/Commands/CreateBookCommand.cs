using tech_interview_api.Application.Books.Models;
using tech_interview_api.Application.Common;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Books.Commands;

public class CreateBookCommand : IRequest<BookDto>
{
    public required string Title { get; set; }
    public string? Author { get; set; }
}

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookDto>
{
    private readonly ApplicationDbContext applicationDbContext;
    public CreateBookCommandHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    public async Task<BookDto> Handle(CreateBookCommand request)
    {
        Book book = new()
        {
            Title = request.Title,
            Author = request.Author
        };

        await applicationDbContext.Books.AddAsync(book);
        await applicationDbContext.SaveChangesAsync();

        return new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Author = book.Author
        };
    }
}