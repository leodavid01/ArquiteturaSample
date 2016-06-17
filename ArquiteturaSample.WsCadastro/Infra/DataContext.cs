using ArquiteturaSample.DataAcces;
using ArquiteturaSample.WsCadastro.Infra.Mappings;
using ArquiteturaSample.WsCadastro.Model;
using System.Data.Entity;

namespace ArquiteturaSample.WsCadastro.Infra
{
    public class DataContext : BaseDataContext
    {
        public DataContext()
            : base ("ArquiteturaSample") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InstrutorMap());
        }

        public DbSet<Model.Instrutor> Instrutores { get; set; }
    }
}