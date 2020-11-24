namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.MAQUINAS_GIMNASIO")]
    public partial class MAQUINAS_GIMNASIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAQUINAS_GIMNASIO()
        {
            DURACIONES_MAQUINAS = new HashSet<DURACIONES_MAQUINAS>();
        }

        [Key]
        public int MAQUINA_ID { get; set; }

        public int? ZONA_ID { get; set; }

        [StringLength(150)]
        public string NOMBRE { get; set; }

        public bool? ESTADO_MAQUINA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DURACIONES_MAQUINAS> DURACIONES_MAQUINAS { get; set; }

        public virtual ZONAS_GIMNASIO ZONAS_GIMNASIO { get; set; }
    }
}
