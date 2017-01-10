namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_staff_genre_tbl")]
    public partial class review_staff_genre_tbl
    {
        [Key]
        public int tantou_genre_id { get; set; }

        public int seq_no { get; set; }

        [Required]
        [StringLength(128)]
        public string tantou_genre_name { get; set; }

        [Required]
        [StringLength(1024)]
        public string tantou_genre_url { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
