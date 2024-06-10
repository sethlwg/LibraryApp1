using Microsoft.EntityFrameworkCore;

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
        modelBuilder.Entity<Book>(entity => { entity.Property(e => e.Id).IsRequired();});


        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, CopyrightInfo = "© 1925 by F. Scott Fitzgerald" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, CopyrightInfo = "© 1960 by Harper Lee" },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, CopyrightInfo = "© 1949 by George Orwell" },
            new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, CopyrightInfo = "© 1851 by Herman Melville" });

    }
    public DbSet<Book> Books {get; set;}
}