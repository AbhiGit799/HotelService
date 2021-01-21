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
    [Table("tblCountry")]
    public class Country
    {
        [DataMember]
        [Key]
        public int CountryId { get; set; }  //Primary Key for Country Table.

        [DataMember]
        public string CountryName { get; set; }
    }
}