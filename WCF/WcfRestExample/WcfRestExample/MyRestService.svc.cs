using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class MyRestService : IMyRestService
    {
        List<Car> list = null;

        public MyRestService()
        {
            list = new List<Car>();
            Car c = new Car();
            c.Make = "Honda";
            c.Year = 2010;
            list.Add(c);
            Car c2 = new Car();
            c2.Year = 2008;
            c2.Make = "BMW";
            list.Add(c2);
        }
        public string GetData()
        {
            return "Hello World";
        }

        private Car getCar(string id)
        {
            Car c = new Car();
            c.Year = 2012;
            c.Make = "Honda";
            return c;

        }
        private List<Car> GetAllCars()
        {
            
           
            return list;
        }

        
        public Car GetCarXml(string id)
        {
            return getCar(id);
        }
        
        public Car GetCarJSON(string id)
        {
            return getCar(id);
        }

        public List<Car> GetAllCarsJson()
        {
            return GetAllCars();
        }


        public List<Car> GetAllCarsXml()
        {
            return GetAllCars();
        }

        public bool AddCar(Car c2) {

            Console.WriteLine("Car Added");
            Car newCar = new Car();
            newCar.Year = c2.Year;
            newCar.Make = c2.Make;
            list.Add(newCar);
            return true;
        
        }

        public string DeleteCar(string id)
        {
            //
            string text = "The car with Id  = " + id + " will be deleted from the system";
            return text;
        }

        public string UpdateCar(string id, Car c)
        {
            string text = "The car with Id  = " + id + " will be updated from the system";
            return text;
        }
    }
}
