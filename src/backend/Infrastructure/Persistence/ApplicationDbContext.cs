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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Loan>().HasOne<Member>().WithMany().HasForeignKey(l => l.MemberId);
        modelBuilder.Entity<Loan>().HasOne<Book>().WithMany().HasForeignKey(l => l.BookId);
    }
}