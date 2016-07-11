using RPC.Common.Communitaion;
using RPC.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RPC.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceProxy<IFooService> proxy = new ServiceProxy<IFooService>())
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                for (int i = 0; i < 10000; i++)
                {
                    var str = proxy.Channel.IFoo();
                    Console.WriteLine(str);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed.TotalSeconds);
            }

            Console.Read();
        }
    }
}
