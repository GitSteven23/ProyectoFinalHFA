namespace DAL.ModelDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HFA.CLASES_INSTRUCTOR")]
    public partial class CLASES_INSTRUCTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLASE_INSTRUCTOR_ID { get; set; }

        public int INSTRUCTOR_ID { get; set; }

        public int CLASE_ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ESPECIALIDAD_ID { get; set; }

        public virtual CLASES CLASES { get; set; }

        public virtual ESPECIALIDADES ESPECIALIDADES { get; set; }

        public virtual INSTRUCTORES INSTRUCTORES { get; set; }
    }
}
