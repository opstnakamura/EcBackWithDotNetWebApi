namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.session_tbl")]
    public partial class session_tbl
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string sessionid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string id { get; set; }

        [StringLength(2048)]
        public string request { get; set; }

        public DateTime createdate { get; set; }

        public DateTime validdate { get; set; }
    }
}
