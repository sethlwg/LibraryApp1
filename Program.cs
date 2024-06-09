using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LibraryApp1.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseInMemoryDatabase("LibraryDb"));
builder.Services.AddControllers();
builder.Services.AddHttpClient();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<LibraryDbContext>();
    
    // Ensure the database is created
    context.Database.EnsureCreated();

    // Seed the database
    // context.Books.AddRange(
    //     new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, CopyrightInfo = "© 1925 by F. Scott Fitzgerald" },
    //     new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, CopyrightInfo = "© 1960 by Harper Lee" },
    //     new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, CopyrightInfo = "© 1949 by George Orwell" },
    //     new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, CopyrightInfo = "© 1851 by Herman Melville" }
    // );
    //context.SaveChanges();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllers();

app.Run();
