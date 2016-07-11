using RPC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace RPC.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class TestService : IService, IFooService
    {
        string IFooService.IFoo()
        {
            return "IFooService.Foo";
        }

        string IService.IFoo()
        {
            return "IService.Foo";
        }
    }
}
