namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.download_item_db")]
    public partial class download_item_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(16)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }
    }
}
