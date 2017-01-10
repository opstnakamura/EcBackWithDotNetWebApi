namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.investigate_history_db")]
    public partial class investigate_history_db
    {
        public int id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? user_regist_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? user_regist_end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? purchase_start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? purchase_end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? questionnaire_edate { get; set; }

        public int? send_mail_num { get; set; }

        public byte? status { get; set; }
    }
}
