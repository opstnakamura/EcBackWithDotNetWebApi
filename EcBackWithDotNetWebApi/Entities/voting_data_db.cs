namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.voting_data_db")]
    public partial class voting_data_db
    {
        public long id { get; set; }

        public long voting_id { get; set; }

        public int candidate_id { get; set; }
    }
}
