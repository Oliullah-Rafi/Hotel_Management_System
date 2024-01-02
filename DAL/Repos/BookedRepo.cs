using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookedRepo : Repo, IBooked<Room, int, Room>
    {

        public bool Book(int id)
        {
            var AD = (from I in db.Rooms where I.RoomID.Equals(id) select I).FirstOrDefault();
            AD.Status = "Booked !!!";

            try
            {
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
