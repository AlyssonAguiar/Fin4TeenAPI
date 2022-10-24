using Fin4teenAPI.Context;
using Fin4teenAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fin4teenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public BooksController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok(new
            {
                sucess = true,
                data = await _appDbContext.Books.ToListAsync()
            });
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Book>> GetBook(string name)
        {
            var book = await _appDbContext.Books.FindAsync(name);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        
        
        [HttpPost]
        public async Task<IActionResult> CreateBook(Book book)
        {
            book.releaseDate.Replace("-","/");

            _appDbContext.Books.Add(book);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
                {
                    sucess = true,
                    data = book
                });
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> PutBook(string name, Book book)
        {
            if(name != book.name)
            {
                return BadRequest();
            }

            _appDbContext.Entry(book).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(name))
                {
                    return NotFound();
                }
                else
                    throw;
            }
            return NoContent();
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteBook(string name)
        {
            var book = await _appDbContext.Books.FindAsync(name);

            if(book == null)
            {
                return NotFound();
            }

            _appDbContext.Books.Remove(book);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(string name)
        {
            return _appDbContext.Books.Any(e => e.name == name);
        }
    }
}
               
