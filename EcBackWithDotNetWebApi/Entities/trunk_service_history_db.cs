namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_service_history_db")]
    public partial class trunk_service_history_db
    {
        public int id { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? exec_date { get; set; }

        public byte? type { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? sdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? edate { get; set; }

        public int? exec_cnt { get; set; }

        public byte? status { get; set; }
    }
}
