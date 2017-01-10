namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.receipt_item_db")]
    public partial class receipt_item_db
    {
        [Key]
        public int riid { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        public long? sku { get; set; }

        public int? price { get; set; }

        public int? tax { get; set; }

        public int? saletype { get; set; }

        public int? status { get; set; }
    }
}
