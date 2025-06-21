using Microsoft.EntityFrameworkCore;

namespace Pizza.API.Persistence
{
    public class PizzaDbContext(DbContextOptions<PizzaDbContext> options) : DbContext(options)
    {
        public DbSet<Models.Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Pizza>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Models.Pizza>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
