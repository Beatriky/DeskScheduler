using FluxPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace FluxPlanner.Data
{
    public class PlannerContext : DbContext 
    {
        public PlannerContext(DbContextOptions<PlannerContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Floor> Floors { get; set; }
 
    }
}
