namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.tachiyomi_login")]
    public partial class tachiyomi_login
    {
        [Key]
        [StringLength(32)]
        public string user_id { get; set; }

        [Required]
        [StringLength(32)]
        public string login_id { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }
    }
}
