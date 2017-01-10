namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.recommend_counter_db")]
    public partial class recommend_counter_db
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string kind { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime adate { get; set; }

        [StringLength(64)]
        public string tag { get; set; }
    }
}
