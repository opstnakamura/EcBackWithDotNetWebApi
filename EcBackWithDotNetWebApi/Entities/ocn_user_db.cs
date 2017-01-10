namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ocn_user_db")]
    public partial class ocn_user_db
    {
        [Key]
        public int no { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(20)]
        public string aspuserid { get; set; }

        [Required]
        [StringLength(40)]
        public string name { get; set; }

        [Required]
        [StringLength(80)]
        public string email { get; set; }

        [StringLength(80)]
        public string note { get; set; }

        public bool mailmagazine { get; set; }
    }
}
