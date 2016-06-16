using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ArquiteturaSample.DataAcces
{
    public class BaseDataContext : DbContext
    {
        public BaseDataContext(string connectionString)
            : base (connectionString)
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
