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


        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Privilege> Privileges { get; set; }

        public DbSet<RolePrivilege> RolePrivileges { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Composite Primary Key
            modelBuilder.Entity<RolePrivilege>()
                .HasKey(x => new
                {
                    x.RoleId,
                    x.PrivilegeId
                });



            // User -> Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId);



            // Role -> Privilege
            modelBuilder.Entity<RolePrivilege>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePrivileges)
                .HasForeignKey(rp => rp.RoleId);



            // Privilege -> Role
            modelBuilder.Entity<RolePrivilege>()
                .HasOne(rp => rp.Privilege)
                .WithMany(p => p.RolePrivileges)
                .HasForeignKey(rp => rp.PrivilegeId);



            // Default Roles

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    RoleName = "Admin"
                },

                new Role
                {
                    Id = 2,
                    RoleName = "Employee"
                }
            );



            // Default Privileges

            modelBuilder.Entity<Privilege>().HasData(

                new Privilege
                {
                    Id = 1,
                    PrivilegeName = "Create User"
                },

                new Privilege
                {
                    Id = 2,
                    PrivilegeName = "Delete User"
                },

                new Privilege
                {
                    Id = 3,
                    PrivilegeName = "View Profile"
                }

            );



            // Assign privileges to roles

            modelBuilder.Entity<RolePrivilege>().HasData(

                // Admin privileges
                new RolePrivilege
                {
                    RoleId = 1,
                    PrivilegeId = 1
                },

                new RolePrivilege
                {
                    RoleId = 1,
                    PrivilegeId = 2
                },


                // Employee privileges
                new RolePrivilege
                {
                    RoleId = 2,
                    PrivilegeId = 3
                }

            );

        }
    }
}