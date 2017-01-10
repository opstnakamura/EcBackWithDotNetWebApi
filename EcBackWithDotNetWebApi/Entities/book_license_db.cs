namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_license_db")]
    public partial class book_license_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int licenseid { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string kana { get; set; }

        [StringLength(20)]
        public string loginid { get; set; }

        [StringLength(20)]
        public string loginpasswd { get; set; }
    }
}
