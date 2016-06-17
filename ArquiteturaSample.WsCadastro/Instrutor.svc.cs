using System.Linq;
using ArquiteturaSample.WCF.Contract;
using ArquiteturaSample.WsCadastro.Infra;
using System.Collections.Generic;

namespace ArquiteturaSample.WsCadastro
{
    public class Instrutor : IInstrutor
    {
        public IEnumerable<Entity.Instrutor> GetAll()
        {
            var instrutores = null as IEnumerable<Entity.Instrutor>;

            using (var context = new DataContext())
            {
                instrutores = context.Instrutores
                                     .ToArray()
                                     .Select(i => i.ToContract())
                                     .ToArray();
            }

            return instrutores;
        }
    }
}
