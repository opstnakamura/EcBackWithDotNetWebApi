namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.faq_access")]
    public partial class faq_access
    {
        [Key]
        public int access_id { get; set; }

        public int id { get; set; }

        public DateTime access_date { get; set; }

        [StringLength(32)]
        public string userid { get; set; }
    }
}
