namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.vouchers")]
    public partial class vouchers
    {
        [Key]
        [StringLength(32)]
        public string voucher_id { get; set; }

        [Required]
        [StringLength(32)]
        public string verification_key { get; set; }

        [Required]
        [StringLength(32)]
        public string voucher_class { get; set; }

        public DateTime? date_expire { get; set; }

        public bool? valid_flg { get; set; }

        public bool? used_flg { get; set; }

        public DateTime? date_create { get; set; }

        public DateTime? date_change { get; set; }
    }
}
