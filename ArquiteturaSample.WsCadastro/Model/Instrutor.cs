using System;

namespace ArquiteturaSample.WsCadastro.Model
{
    public class Instrutor
    {
        public int InstrutorId { get; set; }
        public string NomeInstrutor { get; set; }
        public DateTime DataCadastro { get; set; }

        public Entity.Instrutor ToContract()
        {
            return new Entity.Instrutor
            {
                InstrutorId = this.InstrutorId,
                NomeInstrutor = this.NomeInstrutor,
                DataCadastro = this.DataCadastro
            };
        }
    }
}