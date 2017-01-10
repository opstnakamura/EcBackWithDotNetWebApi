namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.onetime_entry")]
    public partial class onetime_entry
    {
        [Key]
        [StringLength(32)]
        public string entry_id { get; set; }

        [Required]
        [StringLength(32)]
        public string member_id { get; set; }

        public DateTime? date_created { get; set; }

        public DateTime? date_changed { get; set; }

        public byte? purpose_type { get; set; }

        [StringLength(1024)]
        public string purpose_detail { get; set; }

        public bool? license_flg { get; set; }

        [StringLength(20)]
        public string ad_name { get; set; }
    }
}
