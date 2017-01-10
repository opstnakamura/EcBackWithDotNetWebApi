namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.onetime_download_detail")]
    public partial class onetime_download_detail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string download_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }
    }
}
