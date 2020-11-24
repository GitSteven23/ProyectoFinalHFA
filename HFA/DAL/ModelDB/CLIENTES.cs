namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.CLIENTES")]
    public partial class CLIENTES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTES()
        {
            PAGOS = new HashSet<PAGOS>();
            RESERVAS = new HashSet<RESERVAS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLIENTE_ID { get; set; }

        public int TIPO_DOCUMENTO_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string DOCUMENTO_NUMERO { get; set; }

        [StringLength(150)]
        public string NOMBRES { get; set; }

        public int GENERO_ID { get; set; }

        public int? EDAD { get; set; }

        [Required]
        public string CORREO_ELECTRONICO { get; set; }

        public int PAIS_ID { get; set; }

        public int CIUDAD_ID { get; set; }

        public int GIMNASIO_ID { get; set; }

        public bool? ESTADO_CLIENTE { get; set; }

        public DateTime? FECHA_CLIENTE { get; set; }

        public virtual CIUDADES CIUDADES { get; set; }

        public virtual GENEROS GENEROS { get; set; }

        public virtual GIMNASIOS GIMNASIOS { get; set; }

        public virtual PAISES PAISES { get; set; }

        public virtual TIPOS_DOCUMENTOS TIPOS_DOCUMENTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGOS> PAGOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVAS> RESERVAS { get; set; }
    }
}
