namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_genre_db
    {
        [Key]
        public byte mailgenreid { get; set; }

        [Required]
        [StringLength(50)]
        public string mailgenre_name { get; set; }
    }
}
