using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
       
        [ForeignKey("Booking")]
        public int BookingID { get; set; }

        [Required]
        public string Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }


        [Required]
        public string PaymentMethod { get; set; }

        public virtual Booking Booking { get; set; }


    }
}
