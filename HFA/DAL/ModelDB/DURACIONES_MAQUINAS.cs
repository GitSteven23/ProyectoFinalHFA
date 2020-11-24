namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.DURACIONES_MAQUINAS")]
    public partial class DURACIONES_MAQUINAS
    {
        [Key]
        public int DURACION_ENTRENAMIENTO_ID { get; set; }

        public int ENTRENAMIENTO_ID { get; set; }

        public int MAQUINA_ID { get; set; }

        public int? DURACION_MAQUINA { get; set; }

        public virtual ENTRENAMIENTOS ENTRENAMIENTOS { get; set; }

        public virtual MAQUINAS_GIMNASIO MAQUINAS_GIMNASIO { get; set; }
    }
}
