using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [ForeignKey("Hotel")]
        public int HotelID { get; set; }

       

        [ForeignKey("RoomType")]
        public int TypeID { get; set; }
       

        [Required]
        public string Status { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual RoomType RoomType { get; set; }



    }
}
