namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.DEPARTAMENTOS")]
    public partial class DEPARTAMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTAMENTOS()
        {
            CIUDADES = new HashSet<CIUDADES>();
        }

        [Key]
        public int DEPARTAMENTO_ID { get; set; }

        public int PAIS_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string NOMBRE { get; set; }

        public bool ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CIUDADES> CIUDADES { get; set; }

        public virtual PAISES PAISES { get; set; }
    }
}
