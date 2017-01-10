namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class replace_word_db
    {
        [Key]
        public int replace_id { get; set; }

        public int dealerid { get; set; }

        [Required]
        [StringLength(20)]
        public string replace_word { get; set; }

        [Required]
        [StringLength(3000)]
        public string replace_value { get; set; }
    }
}
