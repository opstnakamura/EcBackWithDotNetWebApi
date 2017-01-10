namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.campaign_history_db")]
    public partial class campaign_history_db
    {
        [Key]
        public int campaign_history_id { get; set; }

        public int campaign_id { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        public bool? registed_user_flag { get; set; }

        [StringLength(26)]
        public string sample_orderid { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        [StringLength(40)]
        public string access_code { get; set; }

        public int status { get; set; }

        public DateTime status_updated { get; set; }

        [StringLength(256)]
        public string mail_err_info { get; set; }

        [StringLength(256)]
        public string user_agent { get; set; }

        public DateTime created { get; set; }
    }
}
