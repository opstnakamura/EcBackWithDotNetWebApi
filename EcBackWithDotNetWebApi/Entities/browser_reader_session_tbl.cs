namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.browser_reader_session_tbl")]
    public partial class browser_reader_session_tbl
    {
        [Key]
        [StringLength(32)]
        public string sessionid { get; set; }

        [Required]
        [StringLength(32)]
        public string ebix { get; set; }

        [Required]
        [StringLength(64)]
        public string keydata { get; set; }

        [StringLength(32)]
        public string ipaddr { get; set; }

        [StringLength(512)]
        public string remarks { get; set; }

        [StringLength(192)]
        public string envid { get; set; }

        public int status { get; set; }

        public DateTime valid_date { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
