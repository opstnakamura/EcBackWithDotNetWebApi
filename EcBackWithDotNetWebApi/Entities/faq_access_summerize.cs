namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.faq_access_summerize")]
    public partial class faq_access_summerize
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int daily_access_num { get; set; }

        public int weekly_access_num { get; set; }

        public int monthly_access_num { get; set; }

        public int total_access_num { get; set; }

        public DateTime createdate { get; set; }
    }
}
