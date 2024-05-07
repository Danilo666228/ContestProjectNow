using ContestProject.Model.EF.Entities;
using System.Data.Entity;

namespace ContestProject.Model.EF
{
    public class ContestDbContext : DbContext
    {
        public ContestDbContext() : base("DbConnectionString")
        {
        }
        public DbSet<Contest> Contests { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contest>()
                .HasMany(m => m.Results)
                .WithRequired(m => m.Contest)
                .HasForeignKey(m => m.ContestId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(m => m.Users)
                .WithRequired(m => m.Role)
                .HasForeignKey(m => m.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}
