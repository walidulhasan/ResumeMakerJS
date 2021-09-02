using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cvMakerApi.Models;

namespace cvMakerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumeMakersController : ControllerBase
    {
        private readonly ResumeDbContext _context;

        public ResumeMakersController(ResumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ResumeMakers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResumeMaker>>> GetresumeMakers()
        {
            return await _context.resumeMakers.ToListAsync();
        }

        // GET: api/ResumeMakers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResumeMaker>> GetResumeMaker(int id)
        {
            var resumeMaker = await _context.resumeMakers.FindAsync(id);

            if (resumeMaker == null)
            {
                return NotFound();
            }

            return resumeMaker;
        }

        // PUT: api/ResumeMakers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResumeMaker(int id, ResumeMaker resumeMaker)
        {
            if (id != resumeMaker.ResumeMakerId)
            {
                return BadRequest();
            }

            _context.Entry(resumeMaker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResumeMakerExists(id))
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

        // POST: api/ResumeMakers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ResumeMaker>> PostResumeMaker(ResumeMaker resumeMaker)
        {
            _context.resumeMakers.Add(resumeMaker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResumeMaker", new { id = resumeMaker.ResumeMakerId }, resumeMaker);
        }

        // DELETE: api/ResumeMakers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResumeMaker(int id)
        {
            var resumeMaker = await _context.resumeMakers.FindAsync(id);
            if (resumeMaker == null)
            {
                return NotFound();
            }

            _context.resumeMakers.Remove(resumeMaker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResumeMakerExists(int id)
        {
            return _context.resumeMakers.Any(e => e.ResumeMakerId == id);
        }
    }
}
