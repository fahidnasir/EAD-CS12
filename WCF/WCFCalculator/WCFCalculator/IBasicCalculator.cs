using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalculator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBasicCalculator" in both code and config file together.
    [ServiceContract]
    public interface IBasicCalculator
    {
        [OperationContract]
        double Add(double first, double second);

        [OperationContract]
        double Subtract(double first, double second);

        [OperationContract]
        double Multiply(double first, double second);

        [OperationContract]
        double Divide(double first, double second);
    }
}
