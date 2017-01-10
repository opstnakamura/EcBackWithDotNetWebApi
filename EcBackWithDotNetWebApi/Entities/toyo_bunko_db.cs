namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.toyo-bunko_db")]
    public partial class toyo_bunko_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int series { get; set; }

        public int? sku { get; set; }
    }
}
