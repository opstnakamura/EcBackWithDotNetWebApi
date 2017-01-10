namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_settings_db
    {
        [Key]
        public byte mail_settingid { get; set; }

        [StringLength(128)]
        public string smtphost { get; set; }

        [StringLength(80)]
        public string mailfrom { get; set; }

        [StringLength(80)]
        public string mailbcc { get; set; }

        [StringLength(200)]
        public string notifyto { get; set; }

        [StringLength(80)]
        public string replyto { get; set; }

        public byte? delete_count { get; set; }

        public byte? errorcount_term { get; set; }
    }
}
