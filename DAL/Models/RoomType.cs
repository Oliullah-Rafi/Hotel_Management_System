using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class RoomType
    {
        [Key]
        public int TypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int PricePerNight { get; set; }

        [Required]
        public int Capacity { get; set; }


        public virtual ICollection<Room> RoomTypes { get; set; }

        public RoomType()
        {
            RoomTypes = new List<Room>();
        }
    }
}
