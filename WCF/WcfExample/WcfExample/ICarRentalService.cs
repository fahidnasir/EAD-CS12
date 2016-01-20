using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICarRentalService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Car GetDataUsingDataContract(Car composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   // [DataContract]
    public class Car
    {
        bool isAvailable = true;
        string company = "City ";

       // [DataMember]
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

      //  [DataMember]
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
}
