namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.access_counter_db")]
    public partial class access_counter_db
    {
        [Key]
        [StringLength(40)]
        public string pageid { get; set; }

        public DateTime? adate { get; set; }

        [StringLength(64)]
        public string url { get; set; }
    }
}
