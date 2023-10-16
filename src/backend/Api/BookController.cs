using Microsoft.AspNetCore.Mvc;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Api;

[ApiController]
[Route("[controller]")]
public class BookController
{
    private readonly ApplicationDbContext applicationDbContext;
    public BookController(ApplicationDbContext applicationDbContext) => this.applicationDbContext = applicationDbContext;

    [HttpGet]
    public IEnumerable<Book> Get() => applicationDbContext.Books;

    [HttpPost]
    public Book Post(Book book)
    {
        applicationDbContext.Books.Add(book);
        applicationDbContext.SaveChanges();
        return book;
    }

    [HttpPut("{id:int}")]
    public Book Put(int id, Book book)
    {
        applicationDbContext.Books.Update(book);
        applicationDbContext.SaveChanges();
        return book;
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        Book? book = applicationDbContext.Books.Find(id);
        applicationDbContext.Books.Remove(book);
        applicationDbContext.SaveChanges();
    }
}