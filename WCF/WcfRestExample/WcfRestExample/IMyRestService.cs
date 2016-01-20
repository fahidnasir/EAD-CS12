using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfRestExample
{
    
    [ServiceContract]
    public interface IMyRestService
    {

        //[OperationContract]
        [WebGet(UriTemplate="/GetSomeData")]
        string GetData();

        
        [WebGet(UriTemplate="/CarPool/xml/{id}",
             ResponseFormat = WebMessageFormat.Xml)]
        Car GetCarXml(string id);


        //[OperationContract]
        [WebGet(UriTemplate = "/CarPool/json/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Car GetCarJSON(string id);

        //[OperationContract]
        [WebGet(UriTemplate = "/CarPool/json/",
            ResponseFormat = WebMessageFormat.Json)]
        List<Car> GetAllCarsXml();

        //[OperationContract]
        [WebGet(UriTemplate = "/CarPool/xml/",
            ResponseFormat = WebMessageFormat.Xml)]
        List<Car> GetAllCarsJson();

        //  [OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/add", Method="POST",
            ResponseFormat = WebMessageFormat.Json)]
        bool AddCar(Car c);


        //[OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/{id}", Method = "DELETE", ResponseFormat = WebMessageFormat.Json)]
        string DeleteCar(string id);

        //[OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/{id}", Method = "PUT", ResponseFormat = WebMessageFormat.Json)]
        string UpdateCar(string id,Car c);
    }


   
}
