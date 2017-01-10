namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_room")]
    public partial class trunk_room
    {
        [Key]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime entry_date { get; set; }

        public byte? priceid { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime? use_limit { get; set; }

        public bool cancel_flg { get; set; }

        public DateTime? cancel_date { get; set; }

        [Required]
        [StringLength(20)]
        public string user_name { get; set; }

        [StringLength(10)]
        public string zipcode { get; set; }

        [Required]
        [StringLength(2)]
        public string prefecturecd { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string street { get; set; }

        [StringLength(50)]
        public string building { get; set; }

        [StringLength(15)]
        public string tel { get; set; }

        public bool sex { get; set; }

        public bool active_flg { get; set; }

        public DateTime? last_login_date { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public bool del_flg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }
    }
}
