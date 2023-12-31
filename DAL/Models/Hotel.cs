﻿using System;
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
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Stars { get; set; }
        [Required]
        public DateTime CheckinTime { get; set; }
        [Required]
        public DateTime CheckoutTime { get; set; }


  /*      public virtual ICollection<Staff> Hotels { get; set; }

        public Hotel()
        {
            Hotels = new List<Staff>();
        }
*/
        public virtual ICollection<Room> Hotels { get; set; }

        public Hotel()
        {
            Hotels = new List<Room>();
        }



    }
}
