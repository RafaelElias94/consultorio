namespace actividad3MiltonElias.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("enfermera")]
    public partial class enfermera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idenfermera { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        public int? Edad { get; set; }

        [StringLength(100)]
        public string Area { get; set; }

        public int? idmedico { get; set; }

        public virtual Medico Medico { get; set; }
    }
}
