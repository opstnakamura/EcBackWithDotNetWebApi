namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_delivery_user_item_tbl")]
    public partial class trunk_delivery_user_item_tbl
    {
        [Key]
        public int trunk_delivery_user_item_id { get; set; }

        public int trunk_delivery_detail_id { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public long sku { get; set; }

        public byte status { get; set; }

        public DateTime? exec_date { get; set; }

        [StringLength(36)]
        public string procid { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
