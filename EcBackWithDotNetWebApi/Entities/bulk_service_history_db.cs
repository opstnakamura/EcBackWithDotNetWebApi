namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.bulk_service_history_db")]
    public partial class bulk_service_history_db
    {
        public int id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? sdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? edate { get; set; }

        public int? send_coupon_num { get; set; }

        public byte? status { get; set; }
    }
}
