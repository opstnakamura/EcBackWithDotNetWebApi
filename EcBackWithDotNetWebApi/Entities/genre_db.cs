namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.genre_db")]
    public partial class genre_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int genreid { get; set; }

        [StringLength(128)]
        public string name { get; set; }

        [StringLength(128)]
        public string kana { get; set; }

        public int? genrecode { get; set; }
    }
}
