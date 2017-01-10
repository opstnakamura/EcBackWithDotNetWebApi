namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_tachiyomi_db")]
    public partial class book_tachiyomi_db
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string dealer_id { get; set; }

        public DateTime? date_created { get; set; }

        public DateTime? date_changed { get; set; }

        public bool? valid_flg { get; set; }
    }
}
