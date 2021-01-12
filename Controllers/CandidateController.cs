using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactDotNetApp.Models;

namespace ReactDotNetApp.Controllers
{
    // CandidateDbContext _context;
    
    [Route("api/controller")]
    [ApiController]
    public class CandidateController: ControllerBase
    {

        private readonly CandidateDbContext _context;
        public CandidateController( CandidateDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetCandidate()
        {
            return await _context.Candidates.ToListAsync();
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetCandidate(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            return candidate;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutCandidate(int id, Candidate candidate)
        {
            // if (id != candidate.id) return BadRequest();
            candidate.id = id;
            
            _context.Entry(candidate).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
                // if (!Candi)
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCandidate", new {id = candidate.id}, candidate);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Candidate>> DeleteCandidate(int id)
        {
            var candidate = await _context.Candidates.FindAsync(id);
            if (candidate == null) return NotFound();
            _context.Candidates.Remove(candidate);
            await _context.SaveChangesAsync();
            return candidate;
        }
    }
}