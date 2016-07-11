using LightInject;
using LightInject.Wcf;
using RPC.IISHost;
using RPC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: System.Web.PreApplicationStartMethod(typeof(Startup), "Initialize")]
namespace RPC.IISHost
{
    public class Startup
    {
        public static void Initialize()
        {
            var container = new ServiceContainer();
            container.RegisterFrom<CompositionRoot>();
            LightInjectServiceHostFactory.Container = container;
        }
    }
}