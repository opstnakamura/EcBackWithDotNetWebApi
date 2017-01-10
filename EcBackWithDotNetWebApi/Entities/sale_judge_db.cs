namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.sale_judge_db")]
    public partial class sale_judge_db
    {
        [Key]
        public DateTime saleday { get; set; }

        public byte judge_status { get; set; }

        public DateTime mod_date { get; set; }

        public DateTime reg_date { get; set; }
    }
}
