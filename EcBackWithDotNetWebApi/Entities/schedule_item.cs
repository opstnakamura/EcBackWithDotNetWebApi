namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.schedule_item")]
    public partial class schedule_item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int schedule_item_id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int schedule_id { get; set; }

        [Required]
        [StringLength(128)]
        public string title { get; set; }

        public DateTime schedule_start_date { get; set; }

        public DateTime schedule_end_date { get; set; }

        public int uni_genre_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string schedule_description { get; set; }

        [Required]
        [StringLength(1024)]
        public string url { get; set; }

        [Required]
        [StringLength(128)]
        public string staff_name { get; set; }

        public bool is_deleted { get; set; }

        [Required]
        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
