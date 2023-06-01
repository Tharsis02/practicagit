using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace carrodecrud.Models;

public partial class CarrosgabrielContext : DbContext
{
    public CarrosgabrielContext()
    {
    }

    public CarrosgabrielContext(DbContextOptions<CarrosgabrielContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Colore>(entity =>
        {
            entity.HasKey(e => e.Color).HasName("PK__colores__900DC6E8B7439D5B");

            entity.ToTable("colores");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Marca1).HasName("PK__marcas__0B62C6F3C5BD5DA6");

            entity.ToTable("marcas");

            entity.Property(e => e.Marca1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("marca");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.Modelo1).HasName("PK__modelos__68A7736800AA993A");

            entity.ToTable("modelos");

            entity.Property(e => e.Modelo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.Tipo1).HasName("PK__tipos__E7F9564861F971BB");

            entity.ToTable("tipos");

            entity.Property(e => e.Tipo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
