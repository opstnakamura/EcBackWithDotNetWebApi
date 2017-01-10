namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_blacklist_history_tbl")]
    public partial class review_blacklist_history_tbl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int reviewer_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int judge_cnt { get; set; }

        public byte judge_status { get; set; }

        public int? judge_staff_id { get; set; }

        public DateTime? judge_date { get; set; }

        public bool judge_kekka_flg { get; set; }

        [StringLength(256)]
        public string judge_kekka_reason { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
