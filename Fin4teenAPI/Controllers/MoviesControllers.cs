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
    public class MoviesControllers : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public MoviesControllers(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(new
            {
                sucess = true,
                data = await _appDbContext.Movies.ToListAsync()
            });
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<Movie>> GetMovies(string name)
        {
            var movie = await _appDbContext.Movies.FindAsync(name);

            if (movie == null)
            {
                return NotFound();
            }

            return movie;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(Movie movie)
        {
            movie.releaseDate.Replace("-", "/");

            _appDbContext.Movies.Add(movie);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                sucess = true,
                data = movie
            });
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> PutMovie(string name, Movie movie)
        {
            if (name != movie.name)
            {
                return BadRequest();
            }

            _appDbContext.Entry(movie).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(name))
                {
                    return NotFound();
                }
                else
                    throw;
            }
            return NoContent();
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteMovie(string name)
        {
            var movie = await _appDbContext.Movies.FindAsync(name);

            if (movie == null)
            {
                return NotFound();
            }

            _appDbContext.Movies.Remove(movie);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieExists(string name)
        {
            return _appDbContext.Movies.Any(e => e.name == name);
        }
    }
}

