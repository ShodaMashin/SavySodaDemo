using Microsoft.EntityFrameworkCore;

namespace SavySodaDemo.Data
{
    public class RazorPagesGameContext : DbContext
    {
        public RazorPagesGameContext (
            DbContextOptions<RazorPagesGameContext> options)
            : base(options)
        {
        }

        public DbSet<SavySodaDemo.Models.Game> Game { get; set; }
    }
}
