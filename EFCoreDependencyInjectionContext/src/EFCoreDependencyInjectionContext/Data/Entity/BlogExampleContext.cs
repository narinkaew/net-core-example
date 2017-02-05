using Microsoft.EntityFrameworkCore;

namespace EFCoreDependencyInjectionContext.Data.Entity
{
    public partial class BlogExampleContext : DbContext
    {
        public BlogExampleContext(DbContextOptions<BlogExampleContext> options) 
            : base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=BlogExample;Trusted_Connection=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }

        public virtual DbSet<Blogs> Blogs { get; set; }
    }
}