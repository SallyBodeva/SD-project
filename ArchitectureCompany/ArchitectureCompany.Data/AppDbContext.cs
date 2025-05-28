
namespace ArchitectureCompany.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.Practices.EnterpriseLibrary.Data;

    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Server=DESKTOP-Q6CP77J; Initial Catalog=ArchitectureCompanyEFNew; Integrated Security=true; Trusted_Connection=true";
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BuildingType> BuildingTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual  DbSet<ProjectClient> ProjectClients { get; set; }
        public virtual DbSet<ProjectEmployee> ProjectEmployees { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectClient>(option =>
            {
                option.HasKey(x => new { x.ProjectId, x.ClientId });
            });
            modelBuilder.Entity<ProjectEmployee>(option =>
            {
                option.HasKey(x => new { x.ProjectId, x.EmployeeId });
            });

            modelBuilder.Entity<Project>(option=>
            {
                option.HasIndex(x => x.Name).IsUnique(true);
            });
            modelBuilder.Entity<Client>(option =>
            {
                option.HasIndex(x => x.PhoneNumber).IsUnique(true);
            });
            modelBuilder.Entity<Employee>(option =>
            {
                option.HasIndex(x => x.PhoneNumber).IsUnique(true);
            });
            modelBuilder.Entity<Department>(option =>
            {
                option.HasIndex(x => x.Name).IsUnique(true);
            });
            modelBuilder.Entity<BuildingType>(option =>
            {
                option.HasIndex(x => x.TypeName).IsUnique(true);
            });

            modelBuilder.Entity<Project>()
                .HasMany(pc => pc.ProjectClients)
                .WithOne(p => p.Project)
                .HasForeignKey(pc => pc.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
     
            modelBuilder.Entity<Employee>()
                .HasMany(pe=>pe.ProjectsEmployee)
                .WithOne(e=>e.Employee)
                .HasForeignKey(pc => pc.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
