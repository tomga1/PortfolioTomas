using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioTomas.Data;
using PortfolioTomas.Models;

namespace PortfolioTomas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobreMiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SobreMiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SobreMi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SobreMi>>> GetSobreMi()
        {
            return await _context.SobreMi.ToListAsync();
        }

        // GET: api/SobreMi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SobreMi>> GetSobreMi(int id)
        {
            var sobreMi = await _context.SobreMi.FindAsync(id);

            if (sobreMi == null)
            {
                return NotFound();
            }

            return sobreMi;
        }

        //// PUT: api/SobreMi/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSobreMi(int id, SobreMi sobreMi)
        //{
        //    if (id != sobreMi.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(sobreMi).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SobreMiExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/SobreMi
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<SobreMi>> PostSobreMi(SobreMi sobreMi)
        //{
        //    _context.SobreMi.Add(sobreMi);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSobreMi", new { id = sobreMi.Id }, sobreMi);
        //}

        //// DELETE: api/SobreMi/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSobreMi(int id)
        //{
        //    var sobreMi = await _context.SobreMi.FindAsync(id);
        //    if (sobreMi == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.SobreMi.Remove(sobreMi);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool SobreMiExists(int id)
        {
            return _context.SobreMi.Any(e => e.Id == id);
        }
    }
}
