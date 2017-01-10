namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.contribution_prohibition_db")]
    public partial class contribution_prohibition_db
    {
        [Key]
        public int prohibition_id { get; set; }

        [Required]
        [StringLength(15)]
        public string ip_address { get; set; }

        public DateTime create_date { get; set; }
    }
}
