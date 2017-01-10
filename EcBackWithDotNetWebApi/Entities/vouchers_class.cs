namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.vouchers_class")]
    public partial class vouchers_class
    {
        [Key]
        [StringLength(32)]
        public string voucher_class { get; set; }

        [StringLength(256)]
        public string name { get; set; }

        public int? dealer_id { get; set; }

        public int? price { get; set; }

        public int? type { get; set; }

        public DateTime? date_effect { get; set; }

        public DateTime? date_create { get; set; }

        public DateTime? date_change { get; set; }
    }
}
