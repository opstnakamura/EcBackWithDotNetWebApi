namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_data_tbl")]
    public partial class review_data_tbl
    {
        [Key]
        public int review_id { get; set; }

        public int reviewer_id { get; set; }

        public byte review_kubun { get; set; }

        [StringLength(10)]
        public string titleid { get; set; }

        [StringLength(64)]
        public string bookid { get; set; }

        public DateTime site_view_date { get; set; }

        public bool nickname_view_flg { get; set; }

        public bool netabare_flg { get; set; }

        public byte review_score { get; set; }

        [StringLength(256)]
        public string review_title { get; set; }

        public string review_text { get; set; }

        public int voted_cnt { get; set; }

        public bool site_view_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
