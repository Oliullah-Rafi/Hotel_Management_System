using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Hotel,int, Hotel> HotelData()
        {
            return new HotelRepo();
        }


        public static IRepo<Booking, int, Booking> BookingData()
        {
            return new BookingRepo();
        }

        public static IRepo<Guest, int, Guest> GuestData()
        {
            return new GuestRepo();
        }

        public static IRepo<Payment, int, Payment> PaymentData()
        {
            return new PaymentRepo();
        }

        public static IRepo<Room, int, Room> RoomData()
        {
            return new RoomRepo();
        }

        public static IRepo<RoomType, int, RoomType> RoomTypeData()
        {
            return new RoomTypeRepo();
        }

        public static IRepo<Staff, int, Staff> StaffData()
        {
            return new StaffRepo();
        }
    }
}
