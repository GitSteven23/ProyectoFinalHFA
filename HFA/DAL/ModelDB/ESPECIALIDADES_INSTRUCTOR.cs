namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.ESPECIALIDADES_INSTRUCTOR")]
    public partial class ESPECIALIDADES_INSTRUCTOR
    {
        [Key]
        public int ESPECIALIDAD_INSTRUCTOR_ID { get; set; }

        public int INSTRUCTOR_ID { get; set; }

        public int ESPECIALIDAD_ID { get; set; }

        public virtual ESPECIALIDADES ESPECIALIDADES { get; set; }

        public virtual INSTRUCTORES INSTRUCTORES { get; set; }
    }
}
