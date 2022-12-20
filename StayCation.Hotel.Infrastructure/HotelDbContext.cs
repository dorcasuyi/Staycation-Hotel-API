using Microsoft.EntityFrameworkCore;
using StayCation.Hotel.Models.Models;

namespace StayCation.Hotel.Infrastructure
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }
        public DbSet<Hotels> Hotels { get; set; } 
        public DbSet<User> User { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Detail> Detail { get; set; }
        public DbSet<HotelAccount> HotelAccount { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

    }
}
