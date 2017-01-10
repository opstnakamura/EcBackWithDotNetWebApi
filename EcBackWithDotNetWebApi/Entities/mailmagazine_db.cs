namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.mailmagazine_db")]
    public partial class mailmagazine_db
    {
        [Key]
        [StringLength(80)]
        public string email { get; set; }

        public bool? manga { get; set; }

        public bool? sogo { get; set; }

        public bool? dyna { get; set; }

        public bool? post { get; set; }

        public bool? girl { get; set; }

        public bool? slow { get; set; }
    }
}
