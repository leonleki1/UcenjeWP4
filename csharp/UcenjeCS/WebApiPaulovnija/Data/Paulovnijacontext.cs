using Microsoft.EntityFrameworkCore;

namespace WebApiPaulovnija.Data
{
    public class Paulovnijacontext : DbContext
    {

        public Paulovnijacontext(DbContextOptions<Paulovnijacontext> opcije) : base(opcije) { }


    }
}
