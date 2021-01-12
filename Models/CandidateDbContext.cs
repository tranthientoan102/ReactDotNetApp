using Microsoft.EntityFrameworkCore;

namespace ReactDotNetApp.Models
{
    public class CandidateDbContext: DbContext
    {
        public CandidateDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Candidate> Candidates { get; set; }

    }
} 