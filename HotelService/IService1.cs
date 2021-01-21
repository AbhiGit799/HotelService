using HotelService.HotelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]

        string InsertCountry(Country Incountry);





        [OperationContract]

        string InsertCity(City Incity);

        [OperationContract]

        string Insertroomtype(RoomType Inroomtype);

        [OperationContract]

        string InsertRoomDetails(RoomDetails Inroomdetails);


        [OperationContract]
        string Addhotel(HotelDetails AH);

        [OperationContract]
        string Upadtehotel(HotelDetails UH);



        [OperationContract]

        List<HotelDetails> getallhotel();

        [OperationContract]

        List<string> GetCountries();

        [OperationContract]

        List<string> GetCities(string countname);

        [OperationContract]

        List<string> GetHoteIdies();

        [OperationContract]

        HotelDetails GetHotelDetails(string Hid);

        [OperationContract]

        List<string> Gethoteroomtype();


        [OperationContract]
        string Removehotel(string RH);

       
   

       
       

      

       




       
    }

}
