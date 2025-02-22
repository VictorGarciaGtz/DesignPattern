using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Models.Data;

public partial class DesignPatternContext : DbContext
{
    public DesignPatternContext()
    {
    }

    public DesignPatternContext(DbContextOptions<DesignPatternContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>(entity =>
        {
            entity.ToTable("Beer");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
