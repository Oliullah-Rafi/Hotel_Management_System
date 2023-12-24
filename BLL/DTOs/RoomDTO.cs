﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RoomDTO
    {
     
        public int RoomID { get; set; }

      
        public int HotelID { get; set; }



       
        public int TypeID { get; set; }


        [Required]
        public string Status { get; set; }


    }
}
