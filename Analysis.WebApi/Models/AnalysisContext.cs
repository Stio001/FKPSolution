using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Analysis.WebApi.Models
{
    public class AnalysisContext : DbContext
    {
        public DbSet<Doc> Docs { get; set; }
        public DbSet<DocPart> DocParts { get; set; }
        public DbSet<DocType> DocTypes { get; set; }

        public AnalysisContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DocType>().HasData(new DocType()
            {
                Id = new Guid("7B1A6906-160A-4045-950F-237DB06ADA50"),
                Name = "Госполитика"
            });

            modelBuilder.Entity<Doc>().HasData(new Doc()
            {
                Id = new Guid("38A4A11B-5D0F-46D2-9C10-C71F964F85AD"),
                Name = "Госполитика 1"
            });
        }
    }
}
