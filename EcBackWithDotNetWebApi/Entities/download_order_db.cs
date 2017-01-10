namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.download_order_db")]
    public partial class download_order_db
    {
        [StringLength(16)]
        public string id { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        public long? bulkid { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }

        [StringLength(256)]
        public string envid { get; set; }

        public int? status { get; set; }
    }
}
