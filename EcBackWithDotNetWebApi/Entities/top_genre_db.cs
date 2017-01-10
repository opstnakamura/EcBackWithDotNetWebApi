namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.top_genre_db")]
    public partial class top_genre_db
    {
        [Key]
        [StringLength(10)]
        public string genrecode { get; set; }

        [Required]
        [StringLength(50)]
        public string genrename { get; set; }

        public byte display_order { get; set; }

        [StringLength(100)]
        public string url { get; set; }
    }
}
