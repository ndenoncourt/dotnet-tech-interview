using Microsoft.EntityFrameworkCore;
using tech_interview_api.Domain;

namespace tech_interview_api.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<Member> Members => Set<Member>();
    public DbSet<Loan> Loans => Set<Loan>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    private static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 100, Title = "The Fellowship of the Ring", Author = "J.R.R. Tolkien" },
            new Book { Id = 200, Title = "The Two Towers", Author = "J.R.R. Tolkien" },
            new Book { Id = 300, Title = "The Return of the King", Author = "J.R.R. Tolkien" },
            new Book { Id = 400, Title = "The Hobbit", Author = "J.R.R. Tolkien" },
            new Book { Id = 500, Title = "The Silmarillion", Author = "J.R.R. Tolkien" }
        );

        modelBuilder.Entity<Member>().HasData(
            new Member { Id = 100, Name = "Yannick R", EmailAddress = "yanick.rondeau@groupehsift.ca", PhoneNumber = "(819) 247-4214" },
            new Member { Id = 200, Name = "John Doe", EmailAddress = "john.doe@gmail.com", PhoneNumber = "(819) 555-5555" },
            new Member { Id = 300, Name = "Jane Doe", EmailAddress = "Jane.D@outlook.com", PhoneNumber = "" }
        );

        modelBuilder.Entity<Loan>().HasData(
            new Loan { Id = 100, MemberId = 100, BookId = 200 },
            new Loan { Id = 200, MemberId = 200, BookId = 300 }
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loan>().HasOne<Member>().WithMany().HasForeignKey(l => l.MemberId);
        modelBuilder.Entity<Loan>().HasOne<Book>().WithMany().HasForeignKey(l => l.BookId);
        Seed(modelBuilder);
    }
}