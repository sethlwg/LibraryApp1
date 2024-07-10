using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp1.Pages
{
    public class CheckoutModel : PageModel
    {
        private  LibraryDbContext _context;
        private  LibraryService _libraryService;

        public CheckoutModel(LibraryDbContext context, LibraryService libraryService)
        {
            _context = context;
            _libraryService = libraryService;
        }

        public Book Book { get; set; }
        public Users Users {get; set;}
        [BindProperty]
        public int BookId {get; set;}
        [BindProperty]
        public int UserId {get; set;}
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Books.FindAsync(id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int BookId, int UserId)
        {
            try 
            {
            var book = _context.Books.FirstOrDefault(b => b.Id == BookId);
            var user = _context.User.FirstOrDefault(u => u.Id == UserId);

            if (book == null || user == null)
            {
                return NotFound();
            }

            if (book.IsCheckedOut)
            {
                TempData["Message"] = "This book is already checked out.";
                return Page();
            }

            var CheckOutDate = DateTime.Now;
            var dueDate = CheckOutDate.AddDays(14);

            book.IsCheckedOut = true;
            book.CheckOutDateAndTime = CheckOutDate; 

            await _context.SaveChangesAsync();

            TempData["Message"] = $"Book '{book.Title}' checked out by {user.Name}.";

            return RedirectToPage("/Index");
            }
           catch (Exception ex)
           {
            Console.WriteLine($"Exception: {ex.Message}");
            Console.WriteLine($"Stack Trace: {ex.StackTrace}");
            TempData["Message"] = "An error occurred while checking out the book.";
            return Page();
           }
        }
    
    }
}
    
