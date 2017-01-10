namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.uni_genre_master")]
    public partial class uni_genre_master
    {
        [Key]
        public int uni_genre_id { get; set; }

        public byte uni_genre_type { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public int display_order { get; set; }

        public int? parent_uni_genre_id { get; set; }

        public bool is_disabled { get; set; }

        public bool is_deleted { get; set; }

        [Required]
        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
