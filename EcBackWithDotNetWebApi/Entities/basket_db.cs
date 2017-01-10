namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.basket_db")]
    public partial class basket_db
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime datechanged { get; set; }

        [StringLength(1100)]
        public string item { get; set; }
    }
}
