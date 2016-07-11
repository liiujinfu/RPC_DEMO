using LightInject;
using LightInject.Wcf;
using RPC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPC.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new ServiceContainer();
            container.RegisterFrom<CompositionRoot>();
            LightInjectServiceHostFactory.Container = container;
            Console.Read();
        }
    }
}
