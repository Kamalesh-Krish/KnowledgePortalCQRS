using System;
using System.Collections.Generic;
using KnowledgePortalCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KnowledgePortalCQRS.Infrastructure.Entities
{
    public partial class KnowledgePortalContext : DbContext
    {
        public KnowledgePortalContext()
        {
        }

        public KnowledgePortalContext(DbContextOptions<KnowledgePortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CredentialsTable> CredentialsTables { get; set; } = null!;
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; } = null!;
        public virtual DbSet<FileCommentsTable> FileCommentsTables { get; set; } = null!;
        public virtual DbSet<FileDetialsTable> FileDetialsTables { get; set; } = null!;
        public virtual DbSet<FileRatingTable> FileRatingTables { get; set; } = null!;
        public virtual DbSet<FileStatusTable> FileStatusTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB;initial catalog=KnowledgePortal;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CredentialsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CredentialsTable");

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Credentia__UserI__37A5467C");
            });

            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1F51036C5");

                entity.ToTable("EmployeeTable");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.DateOfJoining).HasColumnType("date");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeMailId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeMailID");

                entity.Property(e => e.EmployeeRole)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ManagerID");
            });

            modelBuilder.Entity<FileCommentsTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileCommentsTable");

                entity.Property(e => e.FileComments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.HasOne(d => d.File)
                    .WithMany()
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__FileComme__FileI__45F365D3");
            });

            modelBuilder.Entity<FileDetialsTable>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK__FileDeti__6F0F989F51D55ACE");

                entity.ToTable("FileDetialsTable");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FileAverage).HasDefaultValueSql("((0))");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.FileDetialsTables)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__FileDetia__Emplo__3A81B327");
            });

            modelBuilder.Entity<FileRatingTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileRatingTable");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileRating).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatingStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__FileRatin__Emplo__4222D4EF");

                entity.HasOne(d => d.File)
                    .WithMany()
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__FileRatin__FileI__412EB0B6");
            });

            modelBuilder.Entity<FileStatusTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileStatusTable");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Waiting')");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__FileStatu__Emplo__3F466844");

                entity.HasOne(d => d.File)
                    .WithMany()
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK__FileStatu__FileI__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
