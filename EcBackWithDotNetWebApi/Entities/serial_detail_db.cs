namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.serial_detail_db")]
    public partial class serial_detail_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string serialid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string packageid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sku { get; set; }

        public DateTime? date_entered { get; set; }

        [StringLength(26)]
        public string frst_orderid { get; set; }

        public DateTime? date_changed { get; set; }

        [StringLength(26)]
        public string last_orderid { get; set; }

        public bool? rdl_flag { get; set; }

        public int? dl_cnt { get; set; }
    }
}
