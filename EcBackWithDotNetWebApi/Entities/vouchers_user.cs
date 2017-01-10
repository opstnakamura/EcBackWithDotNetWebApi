namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.vouchers_user")]
    public partial class vouchers_user
    {
        [Key]
        [StringLength(32)]
        public string voucher_id { get; set; }

        [Required]
        [StringLength(32)]
        public string user_id { get; set; }

        public int? dealer_id { get; set; }

        public int? status { get; set; }

        public DateTime? date_create { get; set; }

        public DateTime? date_change { get; set; }
    }
}
