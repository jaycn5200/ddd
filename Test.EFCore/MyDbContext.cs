using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Core.Entity;

namespace Test.EFCore
{
   public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=TestDDD;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AdminUserEntity>().ToTable("T_AdminUser");
            modelBuilder.Entity<RoleEntity>().ToTable("T_Role");
            modelBuilder.Entity<PermissionEntity>().ToTable("T_Permission");
            var adminUserRole = modelBuilder.Entity<AdminUserRoleEntity>().ToTable("T_AdmimUserRole");
            adminUserRole.HasOne(a => a.Role).WithMany()
                .HasForeignKey(a => a.RoleId);
            adminUserRole.HasOne(a => a.AdminUser).WithMany()
                .HasForeignKey(a => a.AdminUserId);
            var rolePermission = modelBuilder.Entity<RolePermissionEntity>().ToTable("T_RolePerminssion");

            rolePermission.HasOne(a => a.Role).WithMany()
                .HasForeignKey(a => a.RoleId);
            rolePermission.HasOne(a => a.Permission).WithMany()
                .HasForeignKey(a => a.PermissionId);

        }
        public DbSet<AdminUserEntity> AdminUsers { get; set; }
        public DbSet<AdminUserRoleEntity>  AdminUserRoles { get; set; }
        public DbSet<RoleEntity>  Roles { get; set; }
        public DbSet<PermissionEntity>  Permissions { get; set; }

        public DbSet<RolePermissionEntity>  RolePermissions { get; set; }

    }
}
