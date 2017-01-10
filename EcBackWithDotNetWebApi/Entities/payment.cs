namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.payment")]
    public partial class payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int payid { get; set; }

        public int? mode { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        [StringLength(32)]
        public string abbreviation { get; set; }

        public int? status { get; set; }

        [StringLength(256)]
        public string maintenance { get; set; }

        [StringLength(16)]
        public string paytype { get; set; }

        public int? limit { get; set; }

        [StringLength(32)]
        public string dispname1 { get; set; }

        public int? disporder1 { get; set; }

        public int? dispstatus1 { get; set; }

        [StringLength(32)]
        public string dispname2 { get; set; }
    }
}
