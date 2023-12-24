using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Hotel
    {
        [Key]
        public int HotelID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Starts { get; set; }
        [Required]
        public DateTime CheckinTime { get; set; }
        [Required]
        public DateTime CheckoutTime { get; set; }




    }
}
