namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.newbook_notify_history_tbl")]
    public partial class newbook_notify_history_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int historyid { get; set; }

        public DateTime saleday { get; set; }

        public int? send_success { get; set; }

        public int? send_failure { get; set; }

        public int status { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
