namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.publish_db")]
    public partial class publish_db
    {
        [Key]
        [StringLength(10)]
        public string publishid { get; set; }

        [StringLength(255)]
        public string publisher { get; set; }

        [StringLength(255)]
        public string kana { get; set; }
    }
}
