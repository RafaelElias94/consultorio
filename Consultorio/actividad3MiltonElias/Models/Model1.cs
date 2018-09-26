namespace actividad3MiltonElias.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<enfermera> enfermera { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<enfermera>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<enfermera>()
                .Property(e => e.Apellido)
                .IsFixedLength();

            modelBuilder.Entity<enfermera>()
                .Property(e => e.Area)
                .IsFixedLength();

            modelBuilder.Entity<Medico>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Medico>()
                .Property(e => e.Especialidad)
                .IsFixedLength();

            modelBuilder.Entity<Pacientes>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Pacientes>()
                .Property(e => e.Apellido)
                .IsFixedLength();
        }
    }
}
