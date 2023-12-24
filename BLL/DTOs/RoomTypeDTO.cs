using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
   public class RoomTypeDTO
    {
        
        public int TypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string PricePerNight { get; set; }

        [Required]
        public string Capacity { get; set; }
    }
}
