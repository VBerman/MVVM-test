using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVVM_test.Models
{
    public partial class Session2Context : DbContext
    {
        public Session2Context()
        {
        }

        public Session2Context(DbContextOptions<Session2Context> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetGroup> AssetGroups { get; set; }
        public virtual DbSet<ChangedPart> ChangedParts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentLocation> DepartmentLocations { get; set; }
        public virtual DbSet<EmergencyMaintenance> EmergencyMaintenances { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Session2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.AssetName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.AssetSN)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.WarrantyDate).HasColumnType("date");

                entity.HasOne(d => d.AssetGroup)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.AssetGroupID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assets_AssetGroups");

                entity.HasOne(d => d.DepartmentLocation)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.DepartmentLocationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assets_DepartmentLocations");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.EmployeeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assets_Employees");
            });

            modelBuilder.Entity<AssetGroup>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ChangedPart>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.EmergencyMaintenance)
                    .WithMany(p => p.ChangedParts)
                    .HasForeignKey(d => d.EmergencyMaintenanceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangedParts_EmergencyMaintenances");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.ChangedParts)
                    .HasForeignKey(d => d.PartID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangedParts_Parts");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DepartmentLocation>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentLocations)
                    .HasForeignKey(d => d.DepartmentID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentLocations_Departments");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.DepartmentLocations)
                    .HasForeignKey(d => d.LocationID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentLocations_Locations");
            });

            modelBuilder.Entity<EmergencyMaintenance>(entity =>
            {
                entity.Property(e => e.DescriptionEmergency)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EMEndDate).HasColumnType("date");

                entity.Property(e => e.EMReportDate).HasColumnType("date");

                entity.Property(e => e.EMStartDate).HasColumnType("date");

                entity.Property(e => e.EMTechnicianNote).HasMaxLength(200);

                entity.Property(e => e.OtherConsiderations)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.EmergencyMaintenances)
                    .HasForeignKey(d => d.AssetID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyMaintenances_Assets");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.EmergencyMaintenances)
                    .HasForeignKey(d => d.PriorityID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmergencyMaintenances_Priorities");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
