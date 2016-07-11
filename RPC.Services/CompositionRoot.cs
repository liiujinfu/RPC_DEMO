using LightInject;
using RPC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPC.Services
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IService, TestService>(new PerContainerLifetime());
            serviceRegistry.Register<IFooService, TestService>(new PerContainerLifetime());
        }
    }
}
