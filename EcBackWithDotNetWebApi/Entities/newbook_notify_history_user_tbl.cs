namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.newbook_notify_history_user_tbl")]
    public partial class newbook_notify_history_user_tbl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int historyid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(256)]
        public string nickname { get; set; }

        [StringLength(256)]
        public string email { get; set; }

        public DateTime? senddate { get; set; }

        public int? status { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
