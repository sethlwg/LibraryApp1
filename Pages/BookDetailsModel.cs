using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace LibraryApp1.Pages
{
    public class BookDetailsModel : PageModel
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<BookDetailsModel> _logger;
        public BookDetailsModel(HttpClient httpClient,ILogger<BookDetailsModel> logger )
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            _logger.LogInformation("Fetching book details for ID: {Id}", id);
            Book = await _httpClient.GetFromJsonAsync<Book>($"http://localhost:5232/api/Books/{id}");
            if (Book == null)
            {
                _logger.LogWarning("Book not found for ID: {Id}", id);
                return NotFound();
            }
            _logger.LogInformation("Book details fetched successfully for ID: {Id}", id);
            return Page();
        }
    }
}
