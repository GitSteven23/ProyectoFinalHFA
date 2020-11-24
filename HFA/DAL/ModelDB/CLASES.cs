namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.CLASES")]
    public partial class CLASES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASES()
        {
            CLASES_INSTRUCTOR = new HashSet<CLASES_INSTRUCTOR>();
        }

        [Key]
        public int CLASE_ID { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        [StringLength(50)]
        public string DIA_SEMANA { get; set; }

        public TimeSpan? HORARIO { get; set; }

        public bool? ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASES_INSTRUCTOR> CLASES_INSTRUCTOR { get; set; }
    }
}
