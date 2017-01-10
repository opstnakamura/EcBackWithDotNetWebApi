namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.tachiyomi_user")]
    public partial class tachiyomi_user
    {
        [Key]
        [StringLength(32)]
        public string user_id { get; set; }

        [StringLength(10)]
        public string dealer_id { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }
    }
}
