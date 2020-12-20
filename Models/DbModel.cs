using System.Data.Entity;

namespace Intranet.Models
{
    public partial class DbModel : DbContext
    {
        public DbModel()
            : base("name=DbModel")
        {
        }

        public virtual DbSet<EmployeePages> EmployeePages { get; set; }
        public virtual DbSet<EmployeeRole> EmployeeRole { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Role> Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>()
                .HasMany(e => e.EmployeePages)
                .WithRequired(e => e.Page)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Files)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.EmployeeRole)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);
        }
    }
}
