namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_order_db")]
    public partial class point_campaign_order_db
    {
        [Key]
        [StringLength(32)]
        public string orderid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime purchase_date { get; set; }

        public int basic_point { get; set; }

        public int campaign_point { get; set; }

        public byte status { get; set; }
    }
}
