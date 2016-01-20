using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfRestExample
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Car
    {
        int year;
        string carMake = "Honda ";

        [DataMember]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        [DataMember]
        public string Make
        {
            get { return carMake; }
            set { carMake = value; }
        }
    }
}