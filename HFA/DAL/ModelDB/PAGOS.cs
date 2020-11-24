namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.PAGOS")]
    public partial class PAGOS
    {
        [Key]
        public int PAGO_ID { get; set; }

        public int CLIENTE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string PLAN_CLIENTE { get; set; }

        public int MES { get; set; }

        public int? ANIO { get; set; }

        public bool? ESTADO_PAGO { get; set; }

        public DateTime? FECHA_PAGO { get; set; }

        public bool? GENERA_RECIBO { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }
    }
}
