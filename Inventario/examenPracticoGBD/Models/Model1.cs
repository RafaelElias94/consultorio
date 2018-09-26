namespace examenPracticoGBD.Models
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

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.nombre)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.apellido)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.telefono)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.direccion)
                .IsFixedLength();

            modelBuilder.Entity<Pedido>()
                .Property(e => e.estado_pedido)
                .IsFixedLength();

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.nombre)
                .IsFixedLength();

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.apellido)
                .IsFixedLength();

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.telefono)
                .IsFixedLength();

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.email)
                .IsFixedLength();
        }
    }
}
