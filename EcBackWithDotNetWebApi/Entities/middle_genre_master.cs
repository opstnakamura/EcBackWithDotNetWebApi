namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.middle_genre_master")]
    public partial class middle_genre_master
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long middle_genre_no { get; set; }

        [Required]
        [StringLength(128)]
        public string middle_genre_cd { get; set; }

        [Required]
        [StringLength(128)]
        public string middle_genre_name { get; set; }

        public int display_order { get; set; }
    }
}
