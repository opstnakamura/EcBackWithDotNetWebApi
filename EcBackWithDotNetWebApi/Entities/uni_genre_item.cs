namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.uni_genre_item")]
    public partial class uni_genre_item
    {
        [Key]
        public int uni_genre_item_id { get; set; }

        public int uni_genre_id { get; set; }

        public long middle_genre_no { get; set; }

        [Required]
        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
