namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.branch_db")]
    public partial class branch_db
    {
        [Key]
        [StringLength(16)]
        public string branchid { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(128)]
        public string kana { get; set; }
    }
}
