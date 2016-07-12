using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.DuplexServices.Contracts;
namespace Artech.DuplexServices.Clients
{
    public class CalculateCallback:ICallback
    {
        public void DisplayResult(double x, double y, double result)
        {
            Console.WriteLine(" x + y = {2} when x = {0}, y = {1}", x, y, result);
        }
    }
}
