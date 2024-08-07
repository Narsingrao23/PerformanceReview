using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PerformanceReviewData.Models;

public partial class PerformanceReviewContext : DbContext
{
    public PerformanceReviewContext()
    {
    }

    public PerformanceReviewContext(DbContextOptions<PerformanceReviewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Performance> Performances { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JG657LE;Database=PerformanceReview;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC27583391BC");

            entity.ToTable("Employee");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Contact).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Position).HasMaxLength(100);
        });

        modelBuilder.Entity<Performance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Performance");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProjId).HasColumnName("ProjID");

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_Id");

            entity.HasOne(d => d.Proj).WithMany()
                .HasForeignKey(d => d.ProjId)
                .HasConstraintName("FK_ProjId");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjId).HasName("PK__Project__16212AFC587C4539");

            entity.ToTable("Project");

            entity.Property(e => e.ProjId)
                .ValueGeneratedNever()
                .HasColumnName("ProjID");
            entity.Property(e => e.ProjLocation).HasMaxLength(100);
            entity.Property(e => e.ProjManager).HasMaxLength(100);
            entity.Property(e => e.ProjName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
