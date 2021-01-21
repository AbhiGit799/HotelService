using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HotelService.HotelClasses
{
    [DataContract]
    [Table("tblRoomDetails")]
    public class RoomDetails
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [DataMember]
        public int RId { get; set; }

        [ForeignKey("RId")]
        public virtual RoomType roomtype { get; set; }  //Foreign Key from Roomtypetable.

        [DataMember]
        public int TotalRoomType { get; set; }

        [DataMember]
        public int RateAdult { get; set; }

        [DataMember]
        public int RateChild { get; set; }

        [DataMember]
        public string HotelId { get; set; }


        [ForeignKey("HotelId")]
        public virtual HotelDetails hoteldetail { get; set; } //Foreign Key From HotelDetails.


    }
}