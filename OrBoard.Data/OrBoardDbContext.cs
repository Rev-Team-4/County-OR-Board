using System.Linq;
using Microsoft.EntityFrameworkCore;
using OrBoard.Domain.Models;

namespace OrBoard.Data
{
    public class OrBoardDbContext : DbContext
    {

        public DbSet<Anesthetist> Anesthetists { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<OperatingRoom> OperatingRooms { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Surgeon> Surgeons { get; set; }
        

        public OrBoardDbContext()
        {

        }

        public OrBoardDbContext(DbContextOptions<OrBoardDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server=localhost; initial catalog=OrBoardDb; user id=sa; password=Password12345");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(builder);
        }
    }
}