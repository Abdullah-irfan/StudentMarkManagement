// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentMarkManagement.Entity
{
    public partial class StudentmarkmanagementEntity : DbContext
    {
        public StudentmarkmanagementEntity()
        {
        }

        public StudentmarkmanagementEntity(DbContextOptions<StudentmarkmanagementEntity> options)
            : base(options)
        {
        }

        public virtual DbSet<DepartmentDetail> DepartmentDetail { get; set; }
        public virtual DbSet<StudentMarkDetail> StudentMarkDetail { get; set; }
        public virtual DbSet<StudentPersonalDetail> StudentPersonalDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A46N9C4\\SQLEXPRESS;Initial Catalog=StudentMarkManagement;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DepartmentDetail>(entity =>
            {
                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department_Name).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<StudentMarkDetail>(entity =>
            {
                entity.Property(e => e.Student_Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Student_Name).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.StudentMarkDetail)
                    .HasForeignKey<StudentMarkDetail>(d => d.Student_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentMarkDetail_StudentPersonalDetail");
            });

            modelBuilder.Entity<StudentPersonalDetail>(entity =>
            {
                entity.Property(e => e.Created_Time_Stamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gender).IsUnicode(false);

                entity.Property(e => e.Student_Department).IsUnicode(false);

                entity.Property(e => e.Student_Email).IsUnicode(false);

                entity.Property(e => e.Student_Name).IsUnicode(false);

                entity.Property(e => e.Updated_Time_Stamp).HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}