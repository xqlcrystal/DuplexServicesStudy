using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Artech.DuplexServices.Contracts;
using System.ServiceModel;
namespace Artech.DuplexServices.Services
{
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Single)]
    public class CalculatorService:ICalculator
    {
        public void Add(double x, double y)
        {
            double result = x + y;
            ICallback callback = OperationContext.Current.GetCallbackChannel<ICallback>();
            callback.DisplayResult(x, y, result);
        }
    }
}
