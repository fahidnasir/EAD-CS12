using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BasicCalculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BasicCalculator.svc or BasicCalculator.svc.cs at the Solution Explorer and start debugging.
    public class BasicCalculator : IBasicCalculator
    {
        public double Add(double first, double second)
        {
            return first + second;
        }

        public double Subtract(double first, double second)
        {
            return first - second;
        }

        public double Multiply(double first, double second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }
    }
}
