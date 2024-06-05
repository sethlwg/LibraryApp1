using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApp1.Pages
{
    public class DetailsModel : PageModel
    {
        public Book Book { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Hard-coded list of books
            var allBooks = new List<Book>
            {
                new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, CopyrightInfo = "© 1925 by F. Scott Fitzgerald" },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, CopyrightInfo = "© 1960 by Harper Lee" },
                new Book { Id = 3, Title = "1984", Author = "George Orwell", Year = 1949, CopyrightInfo = "© 1949 by George Orwell" },
                new Book { Id = 4, Title = "Moby Dick", Author = "Herman Melville", Year = 1851, CopyrightInfo = "© 1851 by Herman Melville" }
            };

            Book = allBooks?.FirstOrDefault(b => b.Id == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
