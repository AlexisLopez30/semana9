using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace semana8.Models;

public partial class AlmacenContext : DbContext
{
    public AlmacenContext()
    {
    }

    public AlmacenContext(DbContextOptions<AlmacenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoriaRegistro> CategoriaRegistros { get; set; }

    public virtual DbSet<Contadurium> Contaduria { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<Seguridad> Seguridads { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-2TNF9IDD\\SQLEXPRESS;DataBase=Almacen;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoriaRegistro>(entity =>
        {
            entity.HasKey(e => e.CodCategoria).HasName("PK__Categori__80E580C449459F7F");

            entity.ToTable("Categoria_registro");

            entity.Property(e => e.CodCategoria).HasColumnName("Cod_categoria");
            entity.Property(e => e.Actividad)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Categoria)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ClaseDoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Clase_doc");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Hora");
        });

        modelBuilder.Entity<Contadurium>(entity =>
        {
            entity.HasKey(e => e.IdContaduria).HasName("PK__Contadur__E5B4C58C81C56974");

            entity.Property(e => e.IdContaduria).HasColumnName("Id_contaduria");
            entity.Property(e => e.Clase)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Egresos).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Ingresos).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__01AC28296658C13C");

            entity.ToTable("Empleado");

            entity.Property(e => e.IdEmpleado).HasColumnName("Id_empleado");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NDoc).HasColumnName("N_doc");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Producto__3214EC079A332FF9");

            entity.ToTable("Producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.IdRegistro).HasName("PK__Registro__B803EB1184596FFC");

            entity.ToTable("Registro");

            entity.Property(e => e.IdRegistro).HasColumnName("Id_registro");
            entity.Property(e => e.ClaseDoc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Clase_doc");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.NEmpleado).HasColumnName("N_empleado");
            entity.Property(e => e.TipoCategoria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Tipo_categoria");
        });

        modelBuilder.Entity<Seguridad>(entity =>
        {
            entity.HasKey(e => e.IdSeguridad).HasName("PK__Segurida__53381C318642085E");

            entity.ToTable("Seguridad");

            entity.Property(e => e.IdSeguridad).HasColumnName("Id_seguridad");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Identificador).HasColumnType("text");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Regla)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
