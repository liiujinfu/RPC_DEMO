﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace RPC.Contracts
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string IFoo();
    }
}
