namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.prefecture")]
    public partial class prefecture
    {
        [Key]
        [StringLength(2)]
        public string prefecturecd { get; set; }

        [Column("prefecture")]
        [Required]
        [StringLength(10)]
        public string prefecture1 { get; set; }

        [StringLength(20)]
        public string prefecturekana { get; set; }
    }
}
