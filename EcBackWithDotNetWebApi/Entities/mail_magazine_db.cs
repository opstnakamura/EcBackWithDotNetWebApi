namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_magazine_db
    {
        [Key]
        [StringLength(36)]
        public string mailmagazineid { get; set; }

        public int link_dealerid { get; set; }

        public DateTime sendplan_date { get; set; }

        public byte mailgenreid { get; set; }

        [StringLength(200)]
        public string mailtitle { get; set; }

        public byte sendstatus { get; set; }

        [Column(TypeName = "text")]
        public string html_content { get; set; }

        [Column(TypeName = "text")]
        public string text_content { get; set; }

        [Column(TypeName = "text")]
        public string html_content_rep { get; set; }

        [Column(TypeName = "text")]
        public string text_content_rep { get; set; }

        [StringLength(200)]
        public string notes { get; set; }

        [StringLength(500)]
        public string test_email { get; set; }

        public DateTime? regist_date { get; set; }

        public DateTime? change_date { get; set; }
    }
}
