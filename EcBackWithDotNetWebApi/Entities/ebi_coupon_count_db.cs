namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ebi_coupon_count_db")]
    public partial class ebi_coupon_count_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string purpose { get; set; }

        public int price { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime valid_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime valid_end_date { get; set; }

        public int publish_num { get; set; }

        public int unused_num { get; set; }

        [StringLength(10)]
        public string used_num { get; set; }

        [StringLength(10)]
        public string cancel_num { get; set; }

        [StringLength(10)]
        public string invalid_num { get; set; }

        public long? sum_used_price { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "smalldatetime")]
        public DateTime count_date { get; set; }
    }
}
