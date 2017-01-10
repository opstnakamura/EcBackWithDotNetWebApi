namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_history_db
    {
        [Key]
        public int mailhistoryid { get; set; }

        [Required]
        [StringLength(36)]
        public string mailmagazineid { get; set; }

        public int send_count { get; set; }

        public DateTime sendstart_date { get; set; }

        public int? complete_count { get; set; }

        public int? error_count { get; set; }

        public DateTime? sendend_date { get; set; }

        [Column(TypeName = "text")]
        public string unsent_email { get; set; }
    }
}
