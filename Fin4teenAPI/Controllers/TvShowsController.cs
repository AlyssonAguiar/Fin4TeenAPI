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
    public class TvShowsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public TvShowsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetTvShows()
        {
            return Ok(new
            {
                sucess = true,
                data = await _appDbContext.TvShows.ToListAsync()
            });
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<TvShow>> GetMovies(string name)
        {
            var tvShow = await _appDbContext.TvShows.FindAsync(name);

            if (tvShow == null)
            {
                return NotFound();
            }

            return tvShow;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTvShow(TvShow tvShow)
        {
            tvShow.releaseDate.Replace("-", "/");

            _appDbContext.TvShows.Add(tvShow);
            await _appDbContext.SaveChangesAsync();

            return Ok(new
            {
                sucess = true,
                data = tvShow
            });
        }

        [HttpPut("{name}")]
        public async Task<IActionResult> PutTvShow(string name, TvShow tvShow)
        {
            if (name != tvShow.name)
            {
                return BadRequest();
            }

            _appDbContext.Entry(tvShow).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TvShowExists(name))
                {
                    return NotFound();
                }
                else
                    throw;
            }
            return NoContent();
        }

        [HttpDelete("{name}")]
        public async Task<IActionResult> DeleteTvShow(string name)
        {
            var tvShow = await _appDbContext.Movies.FindAsync(name);

            if (tvShow == null)
            {
                return NotFound();
            }

            _appDbContext.Movies.Remove(tvShow);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool TvShowExists(string name)
        {
            return _appDbContext.TvShows.Any(e => e.name == name);
        }
    }
}

