using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repository.entities;
using Repository.interfaces;

namespace MyDbContext.entities;

public partial class PractiSqlContext : Microsoft.EntityFrameworkCore.DbContext,IContext
{
    public PractiSqlContext()
    {
    }

    public PractiSqlContext(DbContextOptions<PractiSqlContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Child> Children { get; set; }
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-KFF1NP2;Initial Catalog=mySQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.HasKey(e => e.ChildId);

            entity.ToTable("Child");

            entity.Property(e => e.ChildId).HasColumnName("childID");
          
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");

            entity.Property(e => e.IdNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("IDnumber");

            entity.Property(e => e.DateOfBirth)
               .HasColumnType("date")
               .HasColumnName("dateOfBirth");

            entity.Property(e => e.FatherId).HasColumnName("fatherID");
            entity.Property(e => e.MotherId).HasColumnName("motherID");
  
        });


        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId);
            entity.ToTable("User");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("date")
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("firstName");
            entity.Property(e => e.Gender)
                .HasColumnName("gender");
            entity.Property(e => e.Hmo)
                .HasMaxLength(50)
                .HasColumnName("HMO");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("IDnumber");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
