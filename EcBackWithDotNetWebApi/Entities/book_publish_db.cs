namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_publish_db")]
    public partial class book_publish_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sku { get; set; }

        public int? publishid { get; set; }
    }
}
