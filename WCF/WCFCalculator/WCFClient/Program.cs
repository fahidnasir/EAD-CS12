﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BasicCalculatorClient client = new ServiceReference1.BasicCalculatorClient();
            client.Add(10, 20);
        }
    }
}
