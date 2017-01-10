namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.title_sale")]
    public partial class title_sale
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string title_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string dealer_id { get; set; }
    }
}
