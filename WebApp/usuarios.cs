namespace WebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [Required]
        [StringLength(15)]
        public string nombre_usuario { get; set; }

        [Key]
        [StringLength(50)]
        public string clave_usuario { get; set; }
    }
}
