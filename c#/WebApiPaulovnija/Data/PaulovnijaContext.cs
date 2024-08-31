using Microsoft.EntityFrameworkCore;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Data
{
    public class Paulovnijacontext : DbContext
    {

        public Paulovnijacontext(DbContextOptions<Paulovnijacontext> opcije) : base(opcije) { }

        public DbSet<Radnici> Radnik { get; set; }
    }
}
