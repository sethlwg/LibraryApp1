using System.ComponentModel.Design;
//using LibraryApp1.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

public class LibraryDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public LibraryDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired();
            entity.Property(e => e.Author).IsRequired();
            entity.Property(e => e.IsCheckedOut).IsRequired();
            entity.Property(e => e.CheckOutDateAndTime).IsRequired();
            entity.Property(e => e.ReturnDateAndTime).IsRequired();
            // Additional configurations if needed
        });

        modelBuilder.Entity<Users>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.EmailAddress).IsRequired();
            // Additional configurations if needed
        });

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, CopyrightInfo = "© 1925 by F. Scott Fitzgerald" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, CopyrightInfo = "© 1960 by Harper Lee" },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, CopyrightInfo = "© 1949 by George Orwell" },
            new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, CopyrightInfo = "© 1851 by Herman Melville" },
            new Book { Id = 5, Title = "The Hunger Games", Author = "Suzanne Collins", Year = 2008, CopyrightInfo = "© 2008 by Suzanne Collins" }); // Add the new book here

        modelBuilder.Entity<Users>().HasData(
            new Users { Id = 1, Name = "John Doe", EmailAddress = "john.doe@example.com" },
            new Users { Id = 2, Name = "Jane Smith", EmailAddress = "jane.smith@example.com" },
            new Users { Id = 3, Name = "James Hammington", EmailAddress = "james.hammington@example.com" }
        );

    }
    public DbSet<Book> Books {get; set;}
    public DbSet<Users> User{get;set;}
    // public DbSet<IsCheckedOut> IsCheckedOut {get;set;}
    
    public int GetTotalBooksCount() => Books.Count();
    public int GetCheckedOutBooksCount() => Books.Count(b => b.IsCheckedOut);

}