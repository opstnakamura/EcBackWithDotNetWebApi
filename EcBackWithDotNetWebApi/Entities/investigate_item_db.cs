namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.investigate_item_db")]
    public partial class investigate_item_db
    {
        public int id { get; set; }

        public int investigate_history_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? count_date { get; set; }

        public int? purchase { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? send_date { get; set; }

        public byte? status { get; set; }
    }
}
