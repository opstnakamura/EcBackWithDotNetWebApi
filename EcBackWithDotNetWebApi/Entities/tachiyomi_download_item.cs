namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.tachiyomi_download_item")]
    public partial class tachiyomi_download_item
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(26)]
        public string download_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }
    }
}
