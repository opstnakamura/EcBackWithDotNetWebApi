namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.schedule_item_master")]
    public partial class schedule_item_master
    {
        [Key]
        public int schedule_id { get; set; }

        public byte schedule_item_type { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public byte display_color { get; set; }

        public byte display_order { get; set; }

        public bool is_disabled { get; set; }

        public bool is_deleted { get; set; }

        [Required]
        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
