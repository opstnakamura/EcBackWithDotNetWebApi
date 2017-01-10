namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.accountlock_history_tbl")]
    public partial class accountlock_history_tbl
    {
        public int id { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime createdate { get; set; }

        public int status { get; set; }

        [StringLength(1024)]
        public string ipaddress { get; set; }
    }
}
