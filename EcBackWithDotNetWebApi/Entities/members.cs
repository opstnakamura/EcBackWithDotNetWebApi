namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.members")]
    public partial class members
    {
        [Key]
        [StringLength(32)]
        public string member_id { get; set; }

        [StringLength(16)]
        public string login_id { get; set; }

        [StringLength(64)]
        public string password { get; set; }

        [StringLength(256)]
        public string email { get; set; }

        [StringLength(256)]
        public string name { get; set; }

        public DateTime? date_created { get; set; }

        public DateTime? date_changed { get; set; }

        public DateTime? date_logined { get; set; }

        public bool? active_flg { get; set; }

        public bool? login_flg { get; set; }

        public bool? reset_flg { get; set; }
    }
}
