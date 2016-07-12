using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Artech.DuplexServices.Contracts
{
    public interface ICallback
    {
        [OperationContract(IsOneWay=true)]
        void DisplayResult(double x, double y, double result);
    }
}
