namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.coupon_db")]
    public partial class coupon_db
    {
        [Key]
        [StringLength(16)]
        public string couponid { get; set; }

        public int sku { get; set; }

        public int status { get; set; }
    }
}
