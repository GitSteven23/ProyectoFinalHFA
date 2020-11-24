namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.ZONAS_GIMNASIO")]
    public partial class ZONAS_GIMNASIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZONAS_GIMNASIO()
        {
            MAQUINAS_GIMNASIO = new HashSet<MAQUINAS_GIMNASIO>();
            ZONAS_ENTRENAMIENTOS = new HashSet<ZONAS_ENTRENAMIENTOS>();
        }

        [Key]
        public int ZONA_ID { get; set; }

        public int? SEDE_ID { get; set; }

        [StringLength(200)]
        public string NOMBRE { get; set; }

        public bool? ESTADO_ZONA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MAQUINAS_GIMNASIO> MAQUINAS_GIMNASIO { get; set; }

        public virtual SEDES SEDES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZONAS_ENTRENAMIENTOS> ZONAS_ENTRENAMIENTOS { get; set; }
    }
}
