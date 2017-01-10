namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.receipt_order_db")]
    public partial class receipt_order_db
    {
        [Key]
        [StringLength(26)]
        public string orderid { get; set; }

        public DateTime? date_entered { get; set; }

        public DateTime? date_changed { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        public int? allprice { get; set; }

        public int? alltax { get; set; }

        public int? payid { get; set; }

        [StringLength(10)]
        public string dealerid { get; set; }

        public int? status { get; set; }

        [StringLength(200)]
        public string envid { get; set; }

        [StringLength(16)]
        public string agentid { get; set; }

        [StringLength(16)]
        public string branchid { get; set; }
    }
}
