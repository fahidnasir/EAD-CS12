using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Managers
{
    public class NetworkLoggingService : ILoggingService
    {
        public bool Log(string text)
        {
            WebClient wc = new WebClient();
            //other request mechanism.
            return true;
        }
    }
}
