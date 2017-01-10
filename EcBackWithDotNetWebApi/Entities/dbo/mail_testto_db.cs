namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_testto_db
    {
        [Key]
        public int testtoid { get; set; }

        [Required]
        [StringLength(100)]
        public string testto_name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string testto_email { get; set; }
    }
}
