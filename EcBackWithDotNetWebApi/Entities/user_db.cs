namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.user_db")]
    public partial class user_db
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(40)]
        public string nickname { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(40)]
        public string passwd { get; set; }

        public bool? mailmagazine { get; set; }

        [StringLength(10)]
        public string dealerid { get; set; }

        public bool? activeflag { get; set; }

        public bool? vipflag { get; set; }

        [StringLength(60)]
        public string association { get; set; }

        [StringLength(30)]
        public string answer { get; set; }

        public bool? mailmagazine_sogo { get; set; }

        public bool? mailmagazine_dyna { get; set; }

        public bool? mailmagazine_post { get; set; }

        public bool? mailmagazine_girl { get; set; }

        public bool? mailmagazine_slow { get; set; }

        public bool? narisumashi_flag { get; set; }

        public bool? mailmagazine_temp { get; set; }

        public bool? passwdreset_flag { get; set; }

        public bool? mailmagazine_manga2 { get; set; }

        public bool? mailmagazine_period { get; set; }

        public bool? mailmagazine_temp1 { get; set; }

        public bool? mailmagazine_temp2 { get; set; }

        public bool? mailmagazine_temp3 { get; set; }

        public bool? mailmagazine_temp4 { get; set; }

        public bool? mailmagazine_temp5 { get; set; }

        public bool? mailmagazine_temp6 { get; set; }

        public bool? mailmagazine_temp7 { get; set; }

        public bool? mailmagazine_temp8 { get; set; }

        public bool? mailmagazine_temp9 { get; set; }

        public bool? mailmagazine_temp10 { get; set; }

        public DateTime? canceled { get; set; }

        public bool is_enable_ssha { get; set; }

        public DateTime last_login_datetime { get; set; }
    }
}
