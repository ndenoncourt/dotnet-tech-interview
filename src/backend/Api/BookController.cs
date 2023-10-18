using Microsoft.AspNetCore.Mvc;
using tech_interview_api.Application.Books.Commands;
using tech_interview_api.Application.Books.Models;

namespace tech_interview_api.Api;

[ApiController]
[Route("[controller]")]
public class BookController
{
    private readonly GetBooksCommandHandler getBooksCommandHandler;
    private readonly CreateBookCommandHandler createBookCommandHandler;
    private readonly UpdateBookCommandHandler updateBookCommandHandler;
    private readonly RemoveBookCommandHandler removeBookCommandHandler;

    public BookController(
        GetBooksCommandHandler getBooksCommandHandler,
        CreateBookCommandHandler createBookCommandHandler,
        UpdateBookCommandHandler updateBookCommandHandler,
        RemoveBookCommandHandler removeBookCommandHandler
    )
    {
        this.getBooksCommandHandler = getBooksCommandHandler;
        this.createBookCommandHandler = createBookCommandHandler;
        this.updateBookCommandHandler = updateBookCommandHandler;
        this.removeBookCommandHandler = removeBookCommandHandler;
    }

    [HttpGet]
    public async Task<List<BookDto>> Get() => await getBooksCommandHandler.Handle(new GetBooksCommand());

    [HttpPost]
    public async Task<BookDto> Post(CreateBookCommand book) => await createBookCommandHandler.Handle(book);

    [HttpPut("{id:int}")]
    public async Task<BookDto> Put(UpdateBookCommand book) => await updateBookCommandHandler.Handle(book);

    [HttpDelete("{id:int}")]
    public async Task Delete(int id) => await removeBookCommandHandler.Handle(new RemoveBookCommand { Id = id });
}