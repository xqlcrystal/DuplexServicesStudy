using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.DuplexServices.Services;
namespace Artech.DuplexServices.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host=new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();
                Console.WriteLine("Artech.DuplexServices.Hosting has started");
                Console.ReadLine();                
            }
        }
    }
}
