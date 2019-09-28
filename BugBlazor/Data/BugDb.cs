using BugBlazor.Models;
using Microsoft.EntityFrameworkCore;

namespace BugBlazor.Data
{
    public class BugDb:DbContext
    {
        public BugDb(DbContextOptions<BugDb> options)
                : base(options)
            {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Bug> Bugs { get; set; }
        
    }
}