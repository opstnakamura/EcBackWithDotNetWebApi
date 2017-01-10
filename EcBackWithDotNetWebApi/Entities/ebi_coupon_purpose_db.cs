namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ebi_coupon_purpose_db")]
    public partial class ebi_coupon_purpose_db
    {
        [Key]
        [StringLength(10)]
        public string purpose_id { get; set; }

        [Required]
        [StringLength(32)]
        public string purpose { get; set; }

        [Required]
        [StringLength(32)]
        public string create_user { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime valid_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime valid_end_date { get; set; }

        public int price { get; set; }

        public byte kind { get; set; }

        public decimal discount_rate { get; set; }

        public int amount { get; set; }

        [StringLength(80)]
        public string customer { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? publish_date { get; set; }

        public DateTime reg_date { get; set; }
    }
}
