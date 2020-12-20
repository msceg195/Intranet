namespace Intranet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeePages
    {
        public int Id { get; set; }

        public int PageID { get; set; }

        public int EmployeeID { get; set; }

        public virtual Page Page { get; set; }
    }
}
