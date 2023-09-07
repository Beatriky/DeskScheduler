using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluxPlanner.Data
{
    public class PlannerContext : DbContext 
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Floor> Floors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new { UserId = 1, FirstName = "Test", LastName = "Test", Email = "test@t.com", WorkLocation = "WFH" }
            );
        }

    }
}
