using System.Collections.Generic;
using System.ServiceModel;

namespace ArquiteturaSample.WCF.Contract
{
    [ServiceContract]
    public interface IInstrutor
    {
        [OperationContract]
        IEnumerable<Entity.Instrutor> GetAll();
    }
}
