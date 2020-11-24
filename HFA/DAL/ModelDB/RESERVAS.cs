namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.RESERVAS")]
    public partial class RESERVAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVAS()
        {
            ENTRENAMIENTOS = new HashSet<ENTRENAMIENTOS>();
        }

        [Key]
        public int RESERVA_ID { get; set; }

        public int CLIENTE_ID { get; set; }

        public int SEDE_ID { get; set; }

        public DateTime? FECHA_RESERVA { get; set; }

        public TimeSpan? HORA_RESERVA { get; set; }

        public int? DURACION_RESERVA { get; set; }

        public string OBSERVACIONES { get; set; }

        public bool? ESTADO_RESERVA { get; set; }

        public int? RESERVAS_DISPONIBLES { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENTRENAMIENTOS> ENTRENAMIENTOS { get; set; }

        public virtual SEDES SEDES { get; set; }
    }
}
