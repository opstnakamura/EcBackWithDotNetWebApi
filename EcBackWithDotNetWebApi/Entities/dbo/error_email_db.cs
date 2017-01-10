namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class error_email_db
    {
        [Key]
        [StringLength(80)]
        public string email { get; set; }

        public DateTime lasterror_date { get; set; }

        public int? error_count { get; set; }

        public DateTime? regist_date { get; set; }

        public DateTime? change_date { get; set; }
    }
}
