namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_manager_user_db
    {
        [Key]
        [StringLength(36)]
        public string userid { get; set; }

        [Required]
        [StringLength(20)]
        public string loginid { get; set; }

        [Required]
        [StringLength(20)]
        public string loginpwd { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(80)]
        public string email { get; set; }

        [StringLength(50)]
        public string dept { get; set; }

        public byte authority { get; set; }

        public bool? auth1_flag { get; set; }

        public bool? auth2_flag { get; set; }

        public bool? auth3_flag { get; set; }

        public bool? auth4_flag { get; set; }

        public bool? auth5_flag { get; set; }

        public bool? auth6_flag { get; set; }

        public bool? auth7_flag { get; set; }

        public bool? auth8_flag { get; set; }

        public bool? auth9_flag { get; set; }

        public bool? auth10_flag { get; set; }

        public bool delete_flag { get; set; }
    }
}
