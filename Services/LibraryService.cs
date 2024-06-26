using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

public class LibraryService
{
    private LibraryDbContext _context;
    public LibraryService(LibraryDbContext context) 
    {
        _context = context;
    }
    public async Task<bool> Checkout(int BookId, int UserId)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == BookId);

        if (book != null)
        {
            book.IsCheckedOut = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Book> GetBooks(string search)
    {
          
        
        if (!string.IsNullOrEmpty(search))
            {
                return _context.Books.Where(b => b.Title.Contains(search) || b.Author.Contains(search)).ToList();
            }
            else
            {
                return _context.Books.ToList();
            }
    }
}