using Microsoft.EntityFrameworkCore;
using ASPdotnet.Models;

namespace ASPdotnet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users => Set<User>();

        public DbSet<Role> Roles => Set<Role>();

        public DbSet<Privilege> Privileges => Set<Privilege>();

        public DbSet<RolePrivilege> RolePrivileges => Set<RolePrivilege>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePrivilege>()
                .HasKey(rp => new { rp.RoleId, rp.PrivilegeId });

            modelBuilder.Entity<RolePrivilege>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePrivileges)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePrivilege>()
                .HasOne(rp => rp.Privilege)
                .WithMany(p => p.RolePrivileges)
                .HasForeignKey(rp => rp.PrivilegeId);

            base.OnModelCreating(modelBuilder);
        }
    }
}