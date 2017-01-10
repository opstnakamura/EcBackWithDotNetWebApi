namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.transfer_lock_history_tbl")]
    public partial class transfer_lock_history_tbl
    {
        public int id { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime createdate { get; set; }

        [StringLength(1024)]
        public string ipaddress { get; set; }
    }
}
