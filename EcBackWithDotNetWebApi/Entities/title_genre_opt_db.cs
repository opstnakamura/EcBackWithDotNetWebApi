namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.title_genre_opt_db")]
    public partial class title_genre_opt_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string titleid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int genreid { get; set; }
    }
}
