using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Adv_WebDev_FinalProj.Data;
using Adv_WebDev_FinalProj.Models;

namespace Adv_WebDev_FinalProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly Adv_WebDev_FinalProjContext _context;

        public CinemasController(Adv_WebDev_FinalProjContext context)
        {
            _context = context;
        }

        // GET: api/Cinemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cinema>>> GetCinema(string search)
        {

            if (string.IsNullOrWhiteSpace(search))
            {
                //return Ok(search);
                return await _context.Cinema.ToListAsync();

            }
            var cinemas = await _context.Cinema.Where(cinema => cinema.MovieId == int.Parse(search)).ToListAsync();
            return cinemas;
        }

        // GET: api/Cinemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cinema>> GetCinema(int id)
        {
            var cinema = await _context.Cinema.FindAsync(id);

            if (cinema == null)
            {
                return NotFound();
            }

            return cinema;
        }

        // PUT: api/Cinemas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinema(int id, Cinema cinema)
        {
            if (id != cinema.CinemaId)
            {
                return BadRequest();
            }

            _context.Entry(cinema).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CinemaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cinemas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cinema>> PostCinema(Cinema cinema)
        {
            _context.Cinema.Add(cinema);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCinema", new { id = cinema.CinemaId }, cinema);
        }

        // DELETE: api/Cinemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cinema>> DeleteCinema(int id)
        {
            var cinema = await _context.Cinema.FindAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }

            _context.Cinema.Remove(cinema);
            await _context.SaveChangesAsync();

            return cinema;
        }

        private bool CinemaExists(int id)
        {
            return _context.Cinema.Any(e => e.CinemaId == id);
        }
    }
}
