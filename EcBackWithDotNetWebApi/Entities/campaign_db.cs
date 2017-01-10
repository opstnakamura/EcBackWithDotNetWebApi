namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.campaign_db")]
    public partial class campaign_db
    {
        [Key]
        public int campaign_id { get; set; }

        [Required]
        [StringLength(64)]
        public string campaign_code { get; set; }

        [Required]
        [StringLength(64)]
        public string campaign_name { get; set; }

        public DateTime open_date_from { get; set; }

        public DateTime open_date_to { get; set; }

        public int max_dl_count { get; set; }

        [Required]
        [StringLength(10)]
        public string user_regist_dealerid { get; set; }

        [Required]
        [StringLength(10)]
        public string order_dealerid { get; set; }

        public bool existing_user_flag { get; set; }

        public bool enquete_flag { get; set; }

        [StringLength(100)]
        public string enquete_title { get; set; }

        [StringLength(1000)]
        public string enquete_question { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string campaign_rule { get; set; }

        [StringLength(128)]
        public string book_select_file { get; set; }

        [StringLength(128)]
        public string url_issue_mail_file { get; set; }

        [StringLength(128)]
        public string thankyou_mail_file { get; set; }

        public bool delete_flag { get; set; }

        public DateTime created { get; set; }

        public DateTime? updated { get; set; }

        public bool pc_dl_seigen_flag { get; set; }

        public bool sample_dl_flag { get; set; }

        public int enquete_age_flag { get; set; }

        public int enquete_sex_flag { get; set; }

        public int enquete_area_flag { get; set; }

        public int enquete_use_flag { get; set; }

        public int enquete_know_flag { get; set; }

        public int enquete_title_suu { get; set; }

        public int enquete_title_flag { get; set; }

        public int enquete_author_suu { get; set; }

        public int enquete_author_flag { get; set; }

        public bool campaign_rule_flag { get; set; }

        public bool url_send_flag { get; set; }
    }
}
