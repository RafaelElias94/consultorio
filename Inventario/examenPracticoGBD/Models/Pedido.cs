namespace examenPracticoGBD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pedido")]
    public partial class Pedido
    {
        [Key]
        public int id_pedido { get; set; }

        [Column(TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? fecha_pedido { get; set; }

        [Column(TypeName = "date")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime? fecha_envio { get; set; }

        [StringLength(50)]
        [Required]
        public string estado_pedido { get; set; }

        public int? id_cliente { get; set; }

        public int? id_proveedor { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
