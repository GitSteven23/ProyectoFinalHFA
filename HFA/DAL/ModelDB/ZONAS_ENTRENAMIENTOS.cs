namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.ZONAS_ENTRENAMIENTOS")]
    public partial class ZONAS_ENTRENAMIENTOS
    {
        [Key]
        public int ZONA_ENTRENAMIENTO { get; set; }

        public int? ENTRENAMIENTO_ID { get; set; }

        public int? ZONA_ID { get; set; }

        public virtual ENTRENAMIENTOS ENTRENAMIENTOS { get; set; }

        public virtual ZONAS_GIMNASIO ZONAS_GIMNASIO { get; set; }
    }
}
