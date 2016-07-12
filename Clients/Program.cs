﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Artech.DuplexServices.Contracts;
namespace Artech.DuplexServices.Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CalculateCallback());
            using (DuplexChannelFactory<ICalculator> ChannelFactory=new DuplexChannelFactory<ICalculator>(instanceContext,"CalculatorService"))
            {
                ICalculator proxy = ChannelFactory.CreateChannel();
                using(proxy as IDisposable)
                {
                    proxy.Add(1, 2);
                   // Console.ReadLine();
                }
            }

        }
    }
}
