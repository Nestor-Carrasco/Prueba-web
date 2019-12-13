namespace WebApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloWeb : DbContext
    {
        public ModeloWeb()
            : base("name=ModeloWeb_entity")
        {
        }

        public virtual DbSet<carreras> carreras { get; set; }
        public virtual DbSet<participantes> participantes { get; set; }
        public virtual DbSet<seminarios> seminarios { get; set; }
        public virtual DbSet<universidades> universidades { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<carreras>()
                .Property(e => e.des_carrera)
                .IsUnicode(false);

            modelBuilder.Entity<carreras>()
                .HasMany(e => e.participantes)
                .WithRequired(e => e.carreras)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<participantes>()
                .Property(e => e.nombre_completo)
                .IsUnicode(false);

            modelBuilder.Entity<seminarios>()
                .Property(e => e.des_seminario)
                .IsUnicode(false);

            modelBuilder.Entity<seminarios>()
                .HasMany(e => e.participantes)
                .WithRequired(e => e.seminarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<universidades>()
                .Property(e => e.des_universidad)
                .IsUnicode(false);

            modelBuilder.Entity<universidades>()
                .HasMany(e => e.carreras)
                .WithRequired(e => e.universidades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.clave_usuario)
                .IsUnicode(false);
        }
    }
}
