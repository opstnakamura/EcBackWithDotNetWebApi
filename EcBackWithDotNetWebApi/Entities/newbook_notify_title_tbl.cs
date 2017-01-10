namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.newbook_notify_title_tbl")]
    public partial class newbook_notify_title_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string userid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string titleid { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
