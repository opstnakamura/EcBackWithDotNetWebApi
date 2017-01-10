namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.user_option_db")]
    public partial class user_option_db
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(10)]
        public string dealerid { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }

        public int? type { get; set; }

        public int? status { get; set; }

        [StringLength(16)]
        public string agentid { get; set; }

        [StringLength(16)]
        public string branchid { get; set; }

        public bool dmt_visible_flg { get; set; }

        public bool lock_flg { get; set; }

        public DateTime first_login_fail_date { get; set; }

        public DateTime last_login_fail_date { get; set; }

        public int lock_count { get; set; }

        public bool newbook_notify_flg { get; set; }

        public bool transfer_lock_flg { get; set; }

        public DateTime first_transfer_date { get; set; }

        public DateTime last_transfer_date { get; set; }

        public int transfer_count { get; set; }

        public bool buybook_auto_notify_flg { get; set; }
    }
}
