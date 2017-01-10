namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ebi_coupon_db")]
    public partial class ebi_coupon_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int no { get; set; }

        [Required]
        [StringLength(32)]
        public string id { get; set; }

        [StringLength(32)]
        public string create_user { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? valid_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? valid_end_date { get; set; }

        [StringLength(32)]
        public string purpose { get; set; }

        public int? price { get; set; }

        public byte kind { get; set; }

        public byte status { get; set; }

        [StringLength(80)]
        public string customer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? publish_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? use_date { get; set; }

        public int? use_price { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(128)]
        public string goods { get; set; }

        [Column(TypeName = "text")]
        public string available_shop { get; set; }

        [Required]
        [StringLength(10)]
        public string purpose_id { get; set; }

        public decimal discount_rate { get; set; }
    }
}
