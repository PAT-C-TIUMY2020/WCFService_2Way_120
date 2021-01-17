﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFService_2Way_120
{
    [ServiceContract]
    interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void pesanKirim(string user, string pesan);
    }
}
