using System;
using System.Runtime.Serialization;

namespace ArquiteturaSample.Entity
{
    [DataContract]
    public class Instrutor
    {
        [DataMember]
        public int InstrutorId { get; set; }

        [DataMember]
        public string NomeInstrutor { get; set; }

        [DataMember]
        public DateTime DataCadastro { get; set; }
    }
}
