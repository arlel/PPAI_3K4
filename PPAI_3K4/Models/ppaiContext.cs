using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PPAI_3K4.Models
{
    public partial class ppaiContext : DbContext
    {
        public ppaiContext()
        {
        }

        public ppaiContext(DbContextOptions<ppaiContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<CambioEstadoReservaVisita> CambioEstadoReservaVisita { get; set; }
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Escuela> Escuela { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Exposicion> Exposicion { get; set; }
        public virtual DbSet<HorarioEmpleado> HorarioEmpleado { get; set; }
        public virtual DbSet<PublicoDestino> PublicoDestino { get; set; }
        public virtual DbSet<ReservaVisita> ReservaVisita { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<TipoExposicion> TipoExposicion { get; set; }
        public virtual DbSet<TipoVisita> TipoVisita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=ppai;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CambioEstadoReservaVisita>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaHoraFin)
                    .HasColumnName("fechaHoraFin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicio)
                    .HasColumnName("fechaHoraInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdReserva).HasColumnName("idReserva");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.CambioEstadoReservaVisita)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_CambioEstadoReservaVisita_Estado");

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.CambioEstadoReservaVisita)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK_CambioEstadoReservaVisita_ReservaVisita");
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoValidacion).HasColumnName("codigoValidacion");

                entity.Property(e => e.Cuit)
                    .HasColumnName("cuit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dni)
                    .HasColumnName("dni")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("domicilio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fechaIngreso")
                    .HasColumnType("date");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fechaNacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.IdCargo).HasColumnName("idCargo");

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCargoNavigation)
                    .WithMany(p => p.Empleado)
                    .HasForeignKey(d => d.IdCargo)
                    .HasConstraintName("FK_Empleado_Cargo");
            });

            modelBuilder.Entity<Escuela>(entity =>
            {
                entity.Property(e => e.Domicilio)
                    .HasColumnName("domicilio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefCelular)
                    .HasColumnName("telefCelular")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TelefFijo)
                    .HasColumnName("telefFijo")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ambito)
                    .HasColumnName("ambito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exposicion>(entity =>
            {
                entity.Property(e => e.FechaFin)
                    .HasColumnName("fechaFin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFinReplanificada)
                    .HasColumnName("fechaFinReplanificada")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicioReplanificada)
                    .HasColumnName("fechaInicioReplanificada")
                    .HasColumnType("date");

                entity.Property(e => e.HoraApertura).HasColumnName("horaApertura");

                entity.Property(e => e.HoraCierre).HasColumnName("horaCierre");

                entity.Property(e => e.IdTipoExposicion).HasColumnName("idTipoExposicion");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoExposicionNavigation)
                    .WithMany(p => p.Exposicion)
                    .HasForeignKey(d => d.IdTipoExposicion)
                    .HasConstraintName("FK_Exposicion_TipoExposicion");
            });

            modelBuilder.Entity<HorarioEmpleado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HoraIngreso).HasColumnName("horaIngreso");

                entity.Property(e => e.HoraSalida).HasColumnName("horaSalida");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.HorarioEmpleado)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_HorarioEmpleado_Empleado");
            });

            modelBuilder.Entity<PublicoDestino>(entity =>
            {
                entity.Property(e => e.Caracteristicas)
                    .HasColumnName("caracteristicas")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdExposicion).HasColumnName("idExposicion");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdExposicionNavigation)
                    .WithMany(p => p.PublicoDestino)
                    .HasForeignKey(d => d.IdExposicion)
                    .HasConstraintName("FK_PublicoDestino_Exposicion");
            });

            modelBuilder.Entity<ReservaVisita>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantidadAlumnos).HasColumnName("cantidadAlumnos");

                entity.Property(e => e.CantidadAlumnosConfirmada).HasColumnName("cantidadAlumnosConfirmada");

                entity.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");

                entity.Property(e => e.FechaHoraCreacion)
                    .HasColumnName("fechaHoraCreacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHoraReserva)
                    .HasColumnName("fechaHoraReserva")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraFinReal).HasColumnName("horaFinReal");

                entity.Property(e => e.HoraInicioReal).HasColumnName("horaInicioReal");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.IdEscuela).HasColumnName("idEscuela");

                entity.Property(e => e.IdSede).HasColumnName("idSede");

                entity.Property(e => e.NumeroReserva).HasColumnName("numeroReserva");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.ReservaVisita)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK_ReservaVisita_Empleado");

                entity.HasOne(d => d.IdEscuelaNavigation)
                    .WithMany(p => p.ReservaVisita)
                    .HasForeignKey(d => d.IdEscuela)
                    .HasConstraintName("FK_ReservaVisita_Escuela");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.ReservaVisita)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("FK_ReservaVisita_Sede");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.Property(e => e.CantMaxPorGuia).HasColumnName("cantMaxPorGuia");

                entity.Property(e => e.CantMaximaVisitantes).HasColumnName("cantMaximaVisitantes");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoExposicion>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoVisita>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
