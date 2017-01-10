namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.receipt_option_db")]
    public partial class receipt_option_db
    {
        [Key]
        [StringLength(26)]
        public string orderid { get; set; }

        [StringLength(1024)]
        public string memo { get; set; }
    }
}
