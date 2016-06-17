using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ArquiteturaSample.WsCadastro.Infra.Mappings
{
    public class InstrutorMap : EntityTypeConfiguration<Model.Instrutor>
    {
        public InstrutorMap()
        {
            this.HasKey(t => t.InstrutorId);

            this.Property(t => t.InstrutorId).HasColumnName("InstrutorID");
            this.Property(t => t.NomeInstrutor).HasColumnName("Nome_Instrutor");
            this.Property(t => t.DataCadastro).HasColumnName("Data_Cadastro");

            this.ToTable("TB_Instrutor");
        }
    }
}