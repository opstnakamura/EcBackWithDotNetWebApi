namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.heart_beat")]
    public partial class heart_beat
    {
        [Key]
        [StringLength(10)]
        public string TARGET { get; set; }

        public DateTime ALIVE_TIME { get; set; }
    }
}
