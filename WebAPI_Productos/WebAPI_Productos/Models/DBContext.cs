using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Productos.Models;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Productos> Productos { get; set; }

    public virtual DbSet<Proveedores> Proveedores { get; set; }

    public virtual DbSet<TipoProducto> TipoProducto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC2732CBF9CB");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idproveedores).HasColumnName("IDProveedores");
            entity.Property(e => e.Idtipo).HasColumnName("IDTipo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.IdproveedoresNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Idproveedores)
                .HasConstraintName("FK__Productos__IDPro__49C3F6B7");

            entity.HasOne(d => d.IdtipoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.Idtipo)
                .HasConstraintName("FK__Productos__IDPro__48CFD27E");
        });

        modelBuilder.Entity<Proveedores>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Proveedo__3214EC2798943C49");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<TipoProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoProd__3214EC277DAFD7D2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
