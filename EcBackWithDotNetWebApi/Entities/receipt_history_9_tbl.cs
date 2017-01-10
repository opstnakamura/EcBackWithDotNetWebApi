namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.receipt_history_9_tbl")]
    public partial class receipt_history_9_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string userid { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime date_entered { get; set; }

        public DateTime? date_changed { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(26)]
        public string orderid { get; set; }

        public int? allprice { get; set; }

        public int? alltax { get; set; }

        public int? payid { get; set; }

        [Required]
        [StringLength(10)]
        public string dealerid { get; set; }

        public int? status { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int riid { get; set; }

        public long sku { get; set; }

        public int? price { get; set; }

        public int? tax { get; set; }

        public int? saletype { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
