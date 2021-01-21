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
    [Table("tblRoomType")]
    public class RoomType
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RId { get; set; }

        [DataMember]
        public string RoomTyp { get; set; }

    }
}