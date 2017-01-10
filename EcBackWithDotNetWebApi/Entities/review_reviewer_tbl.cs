namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_reviewer_tbl")]
    public partial class review_reviewer_tbl
    {
        [Key]
        public int reviewer_id { get; set; }

        public byte reviewer_kubun { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public int favorite_cnt { get; set; }

        public bool blacklist_flag { get; set; }

        public bool site_view_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
