using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp1.Pages
{
    public class LibraryStatisticsModel : PageModel
    {
        private readonly LibraryService _libraryService;

        public LibraryStatisticsModel(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public int TotalBooks { get; set; }
        public int CheckedOutBooks { get; set; }
        public IList<Book> CheckedOutBooksList { get; set; }

        public void OnGet()
        {
            TotalBooks = _libraryService.GetTotalBooksCount();
            CheckedOutBooks = _libraryService.GetCheckedOutBooksCount();
            CheckedOutBooksList = _libraryService.GetCheckedOutBooks();
        }
    }
}
