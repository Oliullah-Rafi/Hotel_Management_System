using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
   public class BookingDTO
    {
       
        public int BookingID { get; set; }
        public int RoomID { get; set; }
        public int GuestID { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
       [Required]
        public string TotalPrice { get; set; }

    }
}
