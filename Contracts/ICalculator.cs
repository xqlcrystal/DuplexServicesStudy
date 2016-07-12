using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace Artech.DuplexServices.Contracts
{
    [ServiceContract(Namespace="http://www.xqlcyrstal.com",CallbackContract=typeof(ICallback))]
    public interface ICalculator
    {
       // [OperationContract(IsOneWay=true)]
        [OperationContract]
        void Add(double x, double y);
    }
}
