namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.passwd_reset_db")]
    public partial class passwd_reset_db
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(26)]
        public string resetkey { get; set; }

        public DateTime? passwdchanged { get; set; }
    }
}
