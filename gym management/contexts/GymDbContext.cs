using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Reflection;
using gym_management.Entities;
namespace gym_management.contexts
{
    public class GymDbContext :  DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=GymDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }


        public DbSet<Member> Members { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Plan> Plans { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<MemberShip> MemberShips { get; set; }


    }
}
