namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.ESPECIALIDADES")]
    public partial class ESPECIALIDADES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESPECIALIDADES()
        {
            CLASES_INSTRUCTOR = new HashSet<CLASES_INSTRUCTOR>();
            ESPECIALIDADES_INSTRUCTOR = new HashSet<ESPECIALIDADES_INSTRUCTOR>();
        }

        [Key]
        public int ESPECIALIDAD_ID { get; set; }

        [StringLength(50)]
        public string NOMBRE { get; set; }

        public int? INTENSIDAD_HORARIA { get; set; }

        public bool? ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASES_INSTRUCTOR> CLASES_INSTRUCTOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESPECIALIDADES_INSTRUCTOR> ESPECIALIDADES_INSTRUCTOR { get; set; }
    }
}
