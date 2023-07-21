using Microsoft.EntityFrameworkCore;
using SuperHeros.API.Models;

namespace SuperHeros.API.Repo
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
