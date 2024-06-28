using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public void OnGet(string search)
        {
        
            SearchTerm = search;
             Books = _libraryService.GetBooks(search);

        }

        public IActionResult OnGetCheckout(int id)
        {
            bool success = _libraryService.Checkout(id); //call method 

             if (success)
            {
                TempData["Message"] = "Book checked out successfully.";
            }
            else
            {
                TempData["Message"] = "Book not found.";
            }

            return RedirectToPage();
            //(new {search = SearchTerm});
        }
    }
}

