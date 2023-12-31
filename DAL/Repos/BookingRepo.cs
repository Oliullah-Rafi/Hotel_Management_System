using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

    internal class BookingRepo : Repo, IBooking<Booking, int, Booking>
    {
        public Booking Create(Booking obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Booking GetBookking(int id)
        {
            var AD = (from I in db.Bookings where I.GuestID.Equals(id) select I).FirstOrDefault();
            return AD;
        }

        public List<Booking> Read()
        {
            throw new NotImplementedException();
        }

        public Booking Read(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Update(Booking obj)
        {
            throw new NotImplementedException();
        }
    }
}
