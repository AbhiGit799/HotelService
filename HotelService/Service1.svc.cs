using HotelService.HotelClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace HotelService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string InsertCountry(Country Incountry)
        {
            try
            {
                ServiceHotelContextCls TC = new ServiceHotelContextCls();
                TC.countries.Add(Incountry);
                TC.SaveChanges();

                return "1 Row Inserted";

            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();
                return sql.Message;

            }
        }

        public string InsertCity(City Incity)
        {
            try
            {
                ServiceHotelContextCls TC = new ServiceHotelContextCls();
                TC.cities.Add(Incity);
                TC.SaveChanges();

                return "1 Row Inserted";

            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();
                return sql.Message;

            }
        }

        public string Insertroomtype(RoomType Inroomtype)
        {
            try
            {
                ServiceHotelContextCls TC = new ServiceHotelContextCls();
                TC.roomtypes.Add(Inroomtype);
                TC.SaveChanges();

                return "1 Row Inserted";

            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();
                return sql.Message;

            }

        }


        public string InsertRoomDetails(RoomDetails Inroomdetails)
        {
            try
            {
                ServiceHotelContextCls TC = new ServiceHotelContextCls();
                TC.rooms.Add(Inroomdetails);
                TC.SaveChanges();

                return "1 Row Inserted";

            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();
                return sql.Message;

            }

        }


        public string Addhotel(HotelDetails AH)
        {
            try
            {
                ServiceHotelContextCls TC = new ServiceHotelContextCls();
                TC.hotels.Add(AH);
                TC.SaveChanges();
                
                return "Record Saved Successfully";

            }
            catch (DbUpdateException Ex)
            {
                SqlException sql = (SqlException)Ex.GetBaseException();
                return sql.Message;

            }

            catch(Exception EE)
            {
                return "Please Try Again";
            }

        }






        public List<HotelDetails> getallhotel()
        {
           
                using (ServiceHotelContextCls gethotels = new ServiceHotelContextCls())
                {
                    var allhotel = from Gh in gethotels.hotels
                                   select Gh;
                    return allhotel.ToList();
                }

          

            
        }



        public string Removehotel(string RH)
        {
            using(ServiceHotelContextCls Delhotel = new ServiceHotelContextCls())
            {
                try
                {
                   
                    var res = (from D1 in Delhotel.hotels
                               where D1.HotelId == RH
                               select D1).FirstOrDefault();


                    Delhotel.hotels.Remove(res);

                    Delhotel.SaveChanges();

                    return "Data Deleted Successfully";

                }
                catch (DbUpdateException Ex)
                {
                    SqlException sql = (SqlException)Ex.GetBaseException();
                    return sql.Message;

                }

            }
         
        }

        static ServiceHotelContextCls yy = new ServiceHotelContextCls();
        public List<string> GetCountries()
        {
            return yy.countries.Select(x => x.CountryName).ToList();
        }

        public List<string> GetCities(string countname)
        {
            var ans = from S1 in yy.cities
                      join
                      C1 in yy.countries on S1.CountryId equals C1.CountryId
                      where C1.CountryName == countname
                      select S1.CityName;

            return ans.ToList();
        }

        public List<string> GetHoteIdies()
        {
            return yy.hotels.Select(x => x.HotelId).ToList();
        }

        public HotelDetails GetHotelDetails(string Hid)
        {
            using (ServiceHotelContextCls W = new ServiceHotelContextCls())
            {
                return W.hotels.Where(x => x.HotelId == Hid).FirstOrDefault();
            }
        }

        public List<string> Gethoteroomtype()
        {
            return yy.roomtypes.Select(x => x.RoomTyp).ToList();
        }

        public string Upadtehotel(HotelDetails UH)
        {



            //SqlConnection con = new SqlConnection("data source=LAPTOP-OIHMLL23; persist security info=True; initial catalog=HotelJBP;user id=sa;password=abhi123");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("update tblHotelDetails set HotelName=@HotelName where HotelId=@HotelId", con);
            //cmd.Parameters.AddWithValue("@HotelId", UH.HotelId);
            //cmd.Parameters.AddWithValue("@HotelName", UH.HotelName);

            //cmd.ExecuteNonQuery();
            //con.Close();

            //return "1 Row Update";

            try 
            {
                var LE = from L in yy.hotels
                         where L.HotelId == UH.HotelId

                         select L;
                HotelDetails E = LE.First();
                E.HotelName = UH.HotelName;
                E.HotelAddress = UH.HotelAddress;
                E.HotelDes = UH.HotelDes;
                E.ContactNo = UH.ContactNo;
                E.TotalAcRooms = UH.TotalAcRooms;
                E.AcRoomsAdultRate = UH.AcRoomsAdultRate;
                E.AcRoomsChildtRate = UH.AcRoomsChildtRate;
                E.NonAcRoomsAdultRate = UH.NonAcRoomsAdultRate;
                E.NonAcRoomsChildtRate = UH.NonAcRoomsChildtRate;




                yy.SaveChanges();
                return "Data Update Successfully";

            }

            catch(Exception ET)
            {
                return "Please Try Again";
            }

            

        }





        //public string Dthotel(HotelDetails DH)
        //{
        //    string i = DH.ToString();
        //    try
        //    {
        //        ServiceHotelContextCls Delhotel = new ServiceHotelContextCls();

        //        var res = from D1 in Delhotel.hotels
        //                  where D1.HotelId == i
        //                  select D1;

        //        HotelDetails hotelDetails = res.FirstOrDefault();

        //        Delhotel.hotels.Remove(hotelDetails);

        //        Delhotel.SaveChanges();

        //        return "1 Row Deleted";

        //    }
        //    catch(DbUpdateException Ex)
        //    {
        //        SqlException sql = (SqlException)Ex.GetBaseException();
        //        return sql.Message;

        //    }
        // }

        //public HotelDetails get(String g)
        //{
        //    //ServiceHotelContextCls gt = new ServiceHotelContextCls();

        //    //var sh = (from D1 in gt.hotels
        //    //          where D1.HotelId == g
        //    //          select D1).FirstOrDefault();

        //    //return sh;
        //    HotelDetails D1 = null;
        //    ServiceHotelContextCls gt = new ServiceHotelContextCls();

        //    foreach (var item in gt.hotels.ToList())
        //    {
        //        if (item.HotelId == g)
        //        {
        //            D1 = item;
        //        }
        //    }

        //    return D1;

        //}



        //public List<HotelDetails> gethbid(string GHD)
        //{

        //    ServiceHotelContextCls gt = new ServiceHotelContextCls();

        //      var  sh = (from D1 in gt.hotels
        //                  where D1.HotelId == GHD
        //                  select D1);

        //    return sh.ToList();

        //}







    }
}
