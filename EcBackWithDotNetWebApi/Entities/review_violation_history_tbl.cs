namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_violation_history_tbl")]
    public partial class review_violation_history_tbl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int review_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int report_reviewer_id { get; set; }

        public int view_judge_id { get; set; }

        public byte judge_status { get; set; }

        [StringLength(128)]
        public string judge_staff_name { get; set; }

        public DateTime? judge_date { get; set; }

        public bool judge_kekka_flg { get; set; }

        [StringLength(256)]
        public string judge_kekka_reason { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}