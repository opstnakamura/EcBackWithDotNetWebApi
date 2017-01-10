namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.bulk_service_item_db")]
    public partial class bulk_service_item_db
    {
        public int id { get; set; }

        public int bulk_history_id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? count_date { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(32)]
        public string coupon_purpose { get; set; }

        [StringLength(32)]
        public string coupon_id { get; set; }

        public int? price { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? valid_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? valid_end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? send_date { get; set; }

        public byte? status { get; set; }
    }
}
