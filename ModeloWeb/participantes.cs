namespace ModeloWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class participantes
    {
        [Key]
        public int cod_participante { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_completo { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_inscripcion { get; set; }

        public double pga { get; set; }

        public int cod_carrera { get; set; }

        public int cod_seminario { get; set; }

        public virtual carreras carreras { get; set; }

        public virtual seminarios seminarios { get; set; }
    }
}
