namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.contribution_make_id_db")]
    public partial class contribution_make_id_db
    {
        public long id { get; set; }

        public int make { get; set; }
    }
}
