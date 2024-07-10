using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLitePCL;
using System.Collections.Generic;
using System.Linq;


namespace LibraryApp1.Pages
{
    public class IndexModel : PageModel
    {
        private LibraryService _libraryService;// declare a private field to hold reference to LibraryService
        public IndexModel(LibraryService libraryService)// constructor for IndexModel and has instance of libraryService
        {
            _libraryService = libraryService;
        }
        public IList<Book> Books { get; set; }
        public string SearchTerm { get; set; }

        public int TotalBooks {get; set;}
        public int CheckedOutBooks {get; set;}
        public void OnGet(string search)
        {
        
            SearchTerm = search;
            Books = _libraryService.GetBooks(search);
            TotalBooks = _libraryService.GetTotalBooksCount();
            CheckedOutBooks = _libraryService.GetCheckedOutBooksCount();

        }

        public async Task<IActionResult> OnPostCheckout(int BookId, int UserId)
        {
            var success = await _libraryService.Checkout(BookId, UserId); //call method 

             if (success)
            {
                TempData["Message"] = "Book checked out successfully.";
            }
            else
            {
                TempData["Message"] = "Book not found.";
            }

            return RedirectToPage();
        }

        
    }
}

