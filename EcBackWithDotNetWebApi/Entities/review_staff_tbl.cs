namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_staff_tbl")]
    public partial class review_staff_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reviewer_id { get; set; }

        public int seq_no { get; set; }

        [Required]
        [StringLength(32)]
        public string reviewer_name_sei { get; set; }

        [Required]
        [StringLength(32)]
        public string reviewer_name_mei { get; set; }

        [Required]
        [StringLength(40)]
        public string nickname { get; set; }

        public int division_id { get; set; }

        [StringLength(32)]
        public string editor_id { get; set; }

        public int? tantou_genre_id { get; set; }

        [StringLength(1024)]
        public string photo_url { get; set; }

        [StringLength(2048)]
        public string profile { get; set; }

        public bool zaiseki_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
