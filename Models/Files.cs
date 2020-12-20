namespace Intranet.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Files
    {
        public int Id { get; set; }

        public Guid Name { get; set; }

        [Required]
        [StringLength(3)]
        public string FileType { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
