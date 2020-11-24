namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.INSTRUCTORES")]
    public partial class INSTRUCTORES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSTRUCTORES()
        {
            CLASES_INSTRUCTOR = new HashSet<CLASES_INSTRUCTOR>();
            ESPECIALIDADES_INSTRUCTOR = new HashSet<ESPECIALIDADES_INSTRUCTOR>();
        }

        [Key]
        public int INSTRUCTOR_ID { get; set; }

        public int SEDE_ID { get; set; }

        public int GIMNASIO_ID { get; set; }

        public int TIPO_DOCUMENTO_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string DOCUMENTO_NUMERO { get; set; }

        [Required]
        [StringLength(50)]
        public string NOMBRES { get; set; }

        public bool ESTADO_INSTRUCTOR { get; set; }

        public DateTime FECHA_REGISTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASES_INSTRUCTOR> CLASES_INSTRUCTOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESPECIALIDADES_INSTRUCTOR> ESPECIALIDADES_INSTRUCTOR { get; set; }

        public virtual GIMNASIOS GIMNASIOS { get; set; }

        public virtual SEDES SEDES { get; set; }

        public virtual TIPOS_DOCUMENTOS TIPOS_DOCUMENTOS { get; set; }
    }
}
