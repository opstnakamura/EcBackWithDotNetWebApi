namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.package_db")]
    public partial class package_db
    {
        [Key]
        [StringLength(4)]
        public string packageid { get; set; }

        [StringLength(255)]
        public string packagename { get; set; }

        public int? status { get; set; }

        [StringLength(12)]
        public string salesname { get; set; }
    }
}
