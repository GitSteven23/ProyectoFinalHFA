using DAL.ModelDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HFAContext : DbContext
    {
        public HFAContext() : base("name=HFAContext")
        {            
        }

        public virtual DbSet<CIUDADES> CIUDADES { get; set; }
        public virtual DbSet<CLASES> CLASES { get; set; }
        public virtual DbSet<CLASES_INSTRUCTOR> CLASES_INSTRUCTOR { get; set; }
        public virtual DbSet<CLIENTES> CLIENTES { get; set; }
        public virtual DbSet<DEPARTAMENTOS> DEPARTAMENTOS { get; set; }
        public virtual DbSet<DURACIONES_MAQUINAS> DURACIONES_MAQUINAS { get; set; }
        public virtual DbSet<ENTRENAMIENTOS> ENTRENAMIENTOS { get; set; }
        public virtual DbSet<ESPECIALIDADES> ESPECIALIDADES { get; set; }
        public virtual DbSet<ESPECIALIDADES_INSTRUCTOR> ESPECIALIDADES_INSTRUCTOR { get; set; }
        public virtual DbSet<GENEROS> GENEROS { get; set; }
        public virtual DbSet<GIMNASIOS> GIMNASIOS { get; set; }
        public virtual DbSet<INSTRUCTORES> INSTRUCTORES { get; set; }
        public virtual DbSet<MAQUINAS_GIMNASIO> MAQUINAS_GIMNASIO { get; set; }
        public virtual DbSet<PAGOS> PAGOS { get; set; }
        public virtual DbSet<PAISES> PAISES { get; set; }
        public virtual DbSet<RESERVAS> RESERVAS { get; set; }
        public virtual DbSet<SEDES> SEDES { get; set; }
        public virtual DbSet<TIPOS_DOCUMENTOS> TIPOS_DOCUMENTOS { get; set; }
        public virtual DbSet<ZONAS_ENTRENAMIENTOS> ZONAS_ENTRENAMIENTOS { get; set; }
        public virtual DbSet<ZONAS_GIMNASIO> ZONAS_GIMNASIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CIUDADES>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.CIUDADES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CIUDADES>()
                .HasMany(e => e.GIMNASIOS)
                .WithRequired(e => e.CIUDADES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLASES>()
                .HasMany(e => e.CLASES_INSTRUCTOR)
                .WithRequired(e => e.CLASES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.PAGOS)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTES>()
                .HasMany(e => e.RESERVAS)
                .WithRequired(e => e.CLIENTES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPARTAMENTOS>()
                .HasMany(e => e.CIUDADES)
                .WithRequired(e => e.DEPARTAMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ENTRENAMIENTOS>()
                .Property(e => e.NOMBRE_ENTRENAMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ENTRENAMIENTOS>()
                .HasMany(e => e.DURACIONES_MAQUINAS)
                .WithRequired(e => e.ENTRENAMIENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESPECIALIDADES>()
                .HasMany(e => e.CLASES_INSTRUCTOR)
                .WithRequired(e => e.ESPECIALIDADES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESPECIALIDADES>()
                .HasMany(e => e.ESPECIALIDADES_INSTRUCTOR)
                .WithRequired(e => e.ESPECIALIDADES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GENEROS>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.GENEROS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIMNASIOS>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.GIMNASIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIMNASIOS>()
                .HasMany(e => e.INSTRUCTORES)
                .WithRequired(e => e.GIMNASIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSTRUCTORES>()
                .HasMany(e => e.CLASES_INSTRUCTOR)
                .WithRequired(e => e.INSTRUCTORES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INSTRUCTORES>()
                .HasMany(e => e.ESPECIALIDADES_INSTRUCTOR)
                .WithRequired(e => e.INSTRUCTORES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAQUINAS_GIMNASIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<MAQUINAS_GIMNASIO>()
                .HasMany(e => e.DURACIONES_MAQUINAS)
                .WithRequired(e => e.MAQUINAS_GIMNASIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAISES>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.PAISES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAISES>()
                .HasMany(e => e.DEPARTAMENTOS)
                .WithRequired(e => e.PAISES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAISES>()
                .HasMany(e => e.GIMNASIOS)
                .WithRequired(e => e.PAISES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEDES>()
                .HasMany(e => e.INSTRUCTORES)
                .WithRequired(e => e.SEDES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SEDES>()
                .HasMany(e => e.RESERVAS)
                .WithRequired(e => e.SEDES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOS_DOCUMENTOS>()
                .HasMany(e => e.CLIENTES)
                .WithRequired(e => e.TIPOS_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOS_DOCUMENTOS>()
                .HasMany(e => e.GIMNASIOS)
                .WithRequired(e => e.TIPOS_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOS_DOCUMENTOS>()
                .HasMany(e => e.INSTRUCTORES)
                .WithRequired(e => e.TIPOS_DOCUMENTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ZONAS_GIMNASIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);
        }
    }
}
