namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.agent_db")]
    public partial class agent_db
    {
        [Key]
        [StringLength(16)]
        public string agentid { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [StringLength(128)]
        public string kana { get; set; }
    }
}
