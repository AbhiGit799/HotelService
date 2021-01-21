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

    [Table("tblCity")]
    public class City
    {
        [DataMember]
        [Key]
        public int CityId { get; set; }

        [DataMember]
        public string CityName { get; set; }

        //CountryId Foreign Key from Country Table

        [DataMember]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country country { get; set; }

    }
}