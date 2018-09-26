namespace actividad3MiltonElias.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pacientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idpaciente { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        public int? Edad { get; set; }

        public int? idmedico { get; set; }

        public virtual Medico Medico { get; set; }
    }
}
