using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LibraryApp1.Pages
{
   public class ReturnModel : PageModel
    {
        private readonly LibraryService _libraryService;

        public ReturnModel(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [BindProperty]
        public Book Book { get; set; }

        public int BookId {get; set;}

        public IActionResult OnGet(int id)
        {
            Book = _libraryService.GetBookById(id);

            if (Book == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int bookId)
        {
            var success = await _libraryService.ReturnBook(bookId);

            if (success)
            {
                TempData["Message"] = "Book returned successfully.";
            }
            else
            {
                TempData["Error"] = "Failed to return book.";
            }

            return RedirectToPage("/Index");
        }

        public string GetBookImageUrl(Book book) 
        {
            return $"/images/{book.Title.Replace(" ", "_").ToLower()}.jpg";
        }
    }
}