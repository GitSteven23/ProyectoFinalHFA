namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.ENTRENAMIENTOS")]
    public partial class ENTRENAMIENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENTRENAMIENTOS()
        {
            DURACIONES_MAQUINAS = new HashSet<DURACIONES_MAQUINAS>();
            ZONAS_ENTRENAMIENTOS = new HashSet<ZONAS_ENTRENAMIENTOS>();
        }

        [Key]
        public int ENTRENAMIENTO_ID { get; set; }

        public int? RESERVA_ID { get; set; }

        [StringLength(150)]
        public string NOMBRE_ENTRENAMIENTO { get; set; }

        public bool? ESTADO_ENTRENAMIENTO { get; set; }

        public int? DURACION_ENTRENAMIENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DURACIONES_MAQUINAS> DURACIONES_MAQUINAS { get; set; }

        public virtual RESERVAS RESERVAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZONAS_ENTRENAMIENTOS> ZONAS_ENTRENAMIENTOS { get; set; }
    }
}
