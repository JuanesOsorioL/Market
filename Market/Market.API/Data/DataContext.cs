using Market.Shared.Entities;
using System.Collections.Generic;

namespace Market.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base()options)
        {
     
        }
            public DbSet<Country> Countries { get; set; }

        protected override void onModelCreating(ModelBuilder modelBuilder)
        { base.OnModelCreating(modelBuilder) }
    }
    

}