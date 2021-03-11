using Microsoft.EntityFrameworkCore;

namespace Analysis.WebApi.Models.DbModels
{
    public class AnalysisContext : DbContext
    {
        public DbSet<Doc> Docs { get; set; }
        public DbSet<DocPart> DocParts { get; set; }
        public DbSet<DocType> DocTypes { get; set; }
        public DbSet<DocPartType> DocPartTypes { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

        public AnalysisContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
