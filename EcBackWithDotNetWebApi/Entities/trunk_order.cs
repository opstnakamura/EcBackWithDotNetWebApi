namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_order")]
    public partial class trunk_order
    {
        [Key]
        [StringLength(36)]
        public string orderid { get; set; }

        public int? payid { get; set; }

        public byte orderstatus { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        public byte contract_type { get; set; }

        public byte oldpriceid { get; set; }

        public byte priceid { get; set; }

        public int price { get; set; }

        public int tax { get; set; }

        public int allprice { get; set; }

        [StringLength(26)]
        public string receipt_orderid { get; set; }

        public bool? cancelflg { get; set; }

        public DateTime? canceldate { get; set; }

        [StringLength(192)]
        public string envid { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime mod_date { get; set; }

        public DateTime reg_date { get; set; }

        public bool del_flg { get; set; }
    }
}
