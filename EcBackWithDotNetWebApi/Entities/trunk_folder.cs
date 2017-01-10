namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_folder")]
    public partial class trunk_folder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folderid { get; set; }

        [Required]
        [StringLength(40)]
        public string foldername { get; set; }

        public int sort_folder { get; set; }
    }
}
