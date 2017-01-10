namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_delivery_magazine_publish_tbl")]
    public partial class trunk_delivery_magazine_publish_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string publishid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string trunkid { get; set; }

        public bool all_flg { get; set; }

        public bool valid_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
