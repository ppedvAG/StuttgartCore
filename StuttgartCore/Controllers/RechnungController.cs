using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StuttgartCore.Models;

namespace StuttgartCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RechnungController : ControllerBase
    {
        private readonly RechnungContext _context;

        public RechnungController(RechnungContext context)
        {
            _context = context;
        }

        // GET: api/Rechnung
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rechnungen>>> GetRechnungens()
        {
            return await _context.Rechnungens.ToListAsync();
        }

        // GET: api/Rechnung/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rechnungen>> GetRechnungen(int id)
        {
            var rechnungen = await _context.Rechnungens.FindAsync(id);

            if (rechnungen == null)
            {
                return NotFound();
            }

            return rechnungen;
        }

        // PUT: api/Rechnung/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRechnungen(int id, Rechnungen rechnungen)
        {
            if (id != rechnungen.ID)
            {
                return BadRequest();
            }

            _context.Entry(rechnungen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RechnungenExists(id))
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

        // POST: api/Rechnung
        [HttpPost]
        public async Task<ActionResult<Rechnungen>> PostRechnungen(Rechnungen rechnungen)
        {
            _context.Rechnungens.Add(rechnungen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRechnungen", new { id = rechnungen.ID }, rechnungen);
        }

        // DELETE: api/Rechnung/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Rechnungen>> DeleteRechnungen(int id)
        {
            var rechnungen = await _context.Rechnungens.FindAsync(id);
            if (rechnungen == null)
            {
                return NotFound();
            }

            _context.Rechnungens.Remove(rechnungen);
            await _context.SaveChangesAsync();

            return rechnungen;
        }

        private bool RechnungenExists(int id)
        {
            return _context.Rechnungens.Any(e => e.ID == id);
        }
    }
}
