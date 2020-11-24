namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.TIPOS_DOCUMENTOS")]
    public partial class TIPOS_DOCUMENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPOS_DOCUMENTOS()
        {
            CLIENTES = new HashSet<CLIENTES>();
            GIMNASIOS = new HashSet<GIMNASIOS>();
            INSTRUCTORES = new HashSet<INSTRUCTORES>();
        }

        [Key]
        public int TIPO_DOCUMENTO_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string NOMBRE { get; set; }

        public bool ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIMNASIOS> GIMNASIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INSTRUCTORES> INSTRUCTORES { get; set; }
    }
}
