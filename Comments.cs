namespace TestDemosran
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comments
    {
        [Key]
        public int commentID { get; set; }

        public string message { get; set; }

        public int? masterID { get; set; }

        public int? requestID { get; set; }

        public virtual Requests Requests { get; set; }

        public virtual Users Users { get; set; }
    }
}
