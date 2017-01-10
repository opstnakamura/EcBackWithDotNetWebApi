namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_price")]
    public partial class trunk_price
    {
        [Key]
        public byte priceid { get; set; }

        [Required]
        [StringLength(50)]
        public string pricename { get; set; }

        public int price { get; set; }

        public int limit { get; set; }

        public byte sort_order { get; set; }

        public bool visible_flg { get; set; }

        public int max_device_num { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public bool del_flg { get; set; }
    }
}
