namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.SEDES")]
    public partial class SEDES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SEDES()
        {
            INSTRUCTORES = new HashSet<INSTRUCTORES>();
            RESERVAS = new HashSet<RESERVAS>();
            ZONAS_GIMNASIO = new HashSet<ZONAS_GIMNASIO>();
        }

        [Key]
        public int SEDE_ID { get; set; }

        public int? GIMNASIO_ID { get; set; }

        [StringLength(50)]
        public string NOMBRE_SEDE { get; set; }

        [StringLength(50)]
        public string UBICACION { get; set; }

        [StringLength(50)]
        public string TELEFONO { get; set; }

        public int? AFORO_TOTAL { get; set; }

        [StringLength(50)]
        public string ADMINISTRADOR { get; set; }

        public bool? SEDE_PRINCIPAL { get; set; }

        public virtual GIMNASIOS GIMNASIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTRUCTORES> INSTRUCTORES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVAS> RESERVAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZONAS_GIMNASIO> ZONAS_GIMNASIO { get; set; }
    }
}
