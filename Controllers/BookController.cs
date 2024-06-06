using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp1.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    { 
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context)
        {
            _context = context;
        }

        //Get: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        //Get: api/Books/1

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

    
    }
}