using Microsoft.EntityFrameworkCore;


using System.Diagnostics.Metrics;

namespace miyabi_API.Data
{
    public class ScratchContext : DbContext
    {
        public ScratchContext(DbContextOptions<ScratchContext> options) : base(options) { }

        //public DbSet<Admin> Admins { get; set; }
       

    }
}
