using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [ForeignKey("Room")]
        public int RoomID { get; set; }

     

        [ForeignKey("Guest")]
        public int GuestID { get; set; }

       

        [Required]
        public DateTime CheckinTime { get; set; }
        [Required]
        public DateTime CheckoutTime { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }
    }
}
