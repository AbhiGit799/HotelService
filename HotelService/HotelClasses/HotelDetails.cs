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
    [Table("tblHotelDetails")]
    public class HotelDetails
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string HotelId { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string HotelAddress { get; set; }

        [DataMember]
        public int ContactNo { get; set; }

        [DataMember]
        public string HotelCity { get; set; }

        [DataMember]
        public string HotelDes { get; set; }

        

        [DataMember]
        public string Country { get; set; }

        //[ForeignKey("CountryId")]
        //public Country country { get; set; }  //Foreign Key From Country Table.

        [DataMember]
        public int TotalAcRooms { get; set; }

        [DataMember]
        public int AcRoomsAdultRate { get; set; }

        [DataMember]
        public int AcRoomsChildtRate { get; set; }

        [DataMember]
        public int TotalNonAcRooms { get; set; }

        [DataMember]
        public int NonAcRoomsAdultRate { get; set; }

        [DataMember]
        public int NonAcRoomsChildtRate { get; set; }

       [DataMember]
        public int TotalRooms { get; set; }


    }
}