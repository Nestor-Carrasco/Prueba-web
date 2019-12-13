namespace ModeloWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class carreras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public carreras()
        {
            participantes = new HashSet<participantes>();
        }

        [Key]
        public int cod_carrera { get; set; }

        [Required]
        [StringLength(90)]
        public string des_carrera { get; set; }

        public int cod_universidad { get; set; }

        public virtual universidades universidades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<participantes> participantes { get; set; }
    }
}
