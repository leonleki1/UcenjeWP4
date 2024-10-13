using Microsoft.EntityFrameworkCore;

namespace WebApiPaulovnija.Data
{
    public class Paulovnijacontext : DbContext
    {

        public Paulovnijacontext(DbContextOptions<Paulovnijacontext> opcije) : base(opcije) { }

        public DbSet<Radnici>Smjerovi { get; set; }

    }
}
