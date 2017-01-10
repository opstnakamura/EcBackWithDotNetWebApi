namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_status_db
    {
        [Key]
        public byte mail_status { get; set; }

        [StringLength(10)]
        public string mail_status_name { get; set; }
    }
}
