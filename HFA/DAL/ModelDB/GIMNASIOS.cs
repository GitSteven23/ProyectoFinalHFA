namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.GIMNASIOS")]
    public partial class GIMNASIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIMNASIOS()
        {
            CLIENTES = new HashSet<CLIENTES>();
            INSTRUCTORES = new HashSet<INSTRUCTORES>();
            SEDES1 = new HashSet<SEDES>();
        }

        [Key]
        public int GIMNASIO_ID { get; set; }

        public int TIPO_DOCUMENTO_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DOCUMENTO_NUMERO { get; set; }

        [Required]
        [StringLength(200)]
        public string RAZON_SOCIAL { get; set; }

        [Required]
        public string CORREO_ELECTRONICO { get; set; }

        public int PAIS_ID { get; set; }

        public int CIUDAD_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string SEDES { get; set; }

        public int AFORO_MAXIMO { get; set; }

        public bool? ESTADO { get; set; }

        public virtual CIUDADES CIUDADES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        public virtual PAISES PAISES { get; set; }

        public virtual TIPOS_DOCUMENTOS TIPOS_DOCUMENTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTRUCTORES> INSTRUCTORES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEDES> SEDES1 { get; set; }
    }
}
