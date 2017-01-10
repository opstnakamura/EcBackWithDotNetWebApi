namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.coupon_detail_db")]
    public partial class coupon_detail_db
    {
        [Key]
        [StringLength(16)]
        public string couponid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(26)]
        public string fast_orderid { get; set; }

        public DateTime? date_changed { get; set; }

        [StringLength(26)]
        public string last_orderid { get; set; }

        public bool rdl_flag { get; set; }

        public int dl_cnt { get; set; }
    }
}
