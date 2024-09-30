using Microsoft.EntityFrameworkCore;

namespace CarQuest.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        { }
        public DbSet<Customers> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>().HasData(
                new Customers
                {
                    ID = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "abc@xyz.edu"
                },
                new Customers
                {
                    ID = 2,
                    FirstName = "James",
                    LastName = "Bond"
                },
                new Customers
                {
                    ID = 3,
                    FirstName = "Tom",
                    LastName = "Cruse"
                },
                new Customers
                {
                    ID = 4,
                    FirstName = "Johnny",
                    LastName = "Depp"
                },
                new Customers
                {
                    ID = 5,
                    FirstName = "Leo",
                    LastName = "Blade"
                }
            );

        }
    }
}
