namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_service_item_db")]
    public partial class trunk_service_item_db
    {
        public int id { get; set; }

        public int trunk_history_id { get; set; }

        [StringLength(36)]
        public string trunkid { get; set; }

        [StringLength(32)]
        public string userid { get; set; }

        public byte? priceid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? use_limit { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? exec_date { get; set; }

        public byte? status { get; set; }
    }
}
