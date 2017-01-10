namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_title_score_tbl")]
    public partial class review_title_score_tbl
    {
        [Key]
        [StringLength(10)]
        public string titleid { get; set; }

        public int total_review_cnt { get; set; }

        public int score1_review_cnt { get; set; }

        public int score2_review_cnt { get; set; }

        public int score3_review_cnt { get; set; }

        public int score4_review_cnt { get; set; }

        public int score5_review_cnt { get; set; }

        public int total_review_score { get; set; }

        public decimal average_review_score { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
