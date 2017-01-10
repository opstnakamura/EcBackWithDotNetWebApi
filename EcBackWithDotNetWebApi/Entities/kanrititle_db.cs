namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.kanrititle_db")]
    public partial class kanrititle_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kanrititleid { get; set; }

        [Required]
        [StringLength(10)]
        public string titleid { get; set; }

        [Required]
        [StringLength(10)]
        public string publishid { get; set; }
    }
}
