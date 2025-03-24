using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyWebApp_MVC.Models;

namespace MyWebApp_MVC.DBLayer;

public partial class FileSystemContext : DbContext
{
    public FileSystemContext()
    {
    }

    public FileSystemContext(DbContextOptions<FileSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FileDetail> FileDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:FileDetailsAdhoc");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FileDetail>(entity =>
        {
            entity.HasKey(e => e.FileId);

            entity.Property(e => e.CorelationId)
                .HasMaxLength(50)
                .HasColumnName("CorelationID");
            entity.Property(e => e.FileCraetedBy).HasMaxLength(50);
            entity.Property(e => e.FileCreatedOn).HasColumnType("datetime");
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.FileType).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
