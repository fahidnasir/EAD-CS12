using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClientApplication.SR1;
namespace MyClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            CarRentalServiceClient myClient = new CarRentalServiceClient();

            string message = myClient.GetData(13);
            Console.WriteLine("message  = " + message);

            Car car = new Car();
            car.IsAvailable = true;
            car.Company = "this is my car";

            Car mySecondCar = myClient.GetDataUsingDataContract(car);

            Console.WriteLine("Car Company = " + mySecondCar.Company);
            myClient.Close();
            Console.ReadKey();
        }
    }
}
