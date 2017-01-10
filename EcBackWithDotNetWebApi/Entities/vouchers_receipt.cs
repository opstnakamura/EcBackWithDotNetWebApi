namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.vouchers_receipt")]
    public partial class vouchers_receipt
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string voucher_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(26)]
        public string order_id { get; set; }

        public int? appropriation { get; set; }

        public DateTime? date_create { get; set; }

        public DateTime? date_change { get; set; }
    }
}
