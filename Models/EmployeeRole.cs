namespace Intranet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeRole")]
    public partial class EmployeeRole
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int EmployeeId { get; set; }

        public virtual Role Role { get; set; }
    }
}
