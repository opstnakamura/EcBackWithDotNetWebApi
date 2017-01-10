namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.receipt_charge_db")]
    public partial class receipt_charge_db
    {
        [Key]
        public int chargeid { get; set; }

        public DateTime date_created { get; set; }

        public int status { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        [Required]
        [StringLength(26)]
        public string orderid { get; set; }

        public int? allprice { get; set; }

        public int? alltax { get; set; }

        public int? payid { get; set; }

        [Required]
        [StringLength(10)]
        public string dealerid { get; set; }

        [StringLength(1024)]
        public string buffer { get; set; }

        [StringLength(1100)]
        public string item { get; set; }

        [StringLength(220)]
        public string item_status { get; set; }

        [StringLength(20)]
        public string remote_addr { get; set; }

        [StringLength(32)]
        public string http_host { get; set; }

        [StringLength(36)]
        public string optionid { get; set; }

        public byte psvtn_mtd { get; set; }
    }
}
