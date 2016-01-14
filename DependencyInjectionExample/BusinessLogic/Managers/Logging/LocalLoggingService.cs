using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Managers
{
    public class LocalLoggingService : ILoggingService
    {
        public bool Log(string text)
        {
            Console.WriteLine(text);
            return true;
        }
    }
}
