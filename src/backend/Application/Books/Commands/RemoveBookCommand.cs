using tech_interview_api.Application.Common;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Books.Commands;

public class RemoveBookCommand : IRequest
{
    public int Id { get; set; }
}

public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand>
{
    private readonly ApplicationDbContext applicationDbContext;
    public RemoveBookCommandHandler(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    public async Task<bool> Handle(RemoveBookCommand request)
    {
        Book? book = await applicationDbContext.Books.FindAsync(request.Id);
        applicationDbContext.Books.Remove(book);
        await applicationDbContext.SaveChangesAsync();
        return true;
    }
}