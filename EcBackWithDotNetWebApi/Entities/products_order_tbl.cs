namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.products_order_tbl")]
    public partial class products_order_tbl
    {
        [Key]
        [StringLength(26)]
        public string products_orderid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public int sku { get; set; }

        [Required]
        [StringLength(20)]
        public string user_name1 { get; set; }

        [Required]
        [StringLength(20)]
        public string user_name2 { get; set; }

        [StringLength(40)]
        public string user_name_kana1 { get; set; }

        [StringLength(40)]
        public string user_name_kana2 { get; set; }

        [Required]
        [StringLength(7)]
        public string zipcode { get; set; }

        [Required]
        [StringLength(2)]
        public string prefecturecd { get; set; }

        [Required]
        [StringLength(60)]
        public string city { get; set; }

        [StringLength(60)]
        public string street { get; set; }

        [StringLength(50)]
        public string building { get; set; }

        [Required]
        [StringLength(13)]
        public string tel { get; set; }

        [StringLength(13)]
        public string tel_daytime { get; set; }

        public byte status { get; set; }

        [StringLength(26)]
        public string receipt_orderid { get; set; }

        public DateTime entry_date { get; set; }

        public DateTime? order_date { get; set; }

        public DateTime? cancel_date { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        [StringLength(26)]
        public string receipt_link_orderid { get; set; }
    }
}
