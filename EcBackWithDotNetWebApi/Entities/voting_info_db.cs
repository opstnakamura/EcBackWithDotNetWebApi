namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.voting_info_db")]
    public partial class voting_info_db
    {
        [Key]
        public long voting_id { get; set; }

        [StringLength(1024)]
        public string title { get; set; }

        public DateTime? strat_date { get; set; }

        public DateTime? end_date { get; set; }

        public int past_disp_flg { get; set; }
    }
}
