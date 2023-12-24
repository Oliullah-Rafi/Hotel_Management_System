namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.HMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.HMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Hotels.Add(new Models.Hotel
                {    
                    HotelID = i,
                    UserName = "User-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),

                    UserType = "Hotel",
                    Name = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Address = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Phone = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Email = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Stars = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    CheckinTime =DateTime.Now,
                    CheckoutTime= DateTime.Now,
                 

                });

     
            }


            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {

                context.Staffs.Add(new Models.Staff
             
                {
                    StaffID = i,
                    HotelID = random.Next(1,11),
                    FirstName = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    LastName = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Position = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Salary = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    DateOfBirth = DateTime.Now,
                    Phone = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Email = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    HireDate = DateTime.Now


                });

            }



            for (int i = 1; i <= 20; i++)
            {

                context.RoomTypes.Add(new Models.RoomType

                {
                    TypeID = i,
                    Name = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Description = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    PricePerNight = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Capacity = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length))


                });

            }



            for (int i = 1; i <= 30; i++)
            {

                context.Guests.Add(new Models.Guest

                {
                    GuestID = i,
                    UserName = "Guest-" + i,
                    Password = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    UserType = "Guest",
                    FirstName = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    LastName = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    DateOfBirth = DateTime.Now,
                    Address = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Phone = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    Email = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length))


                });

            }


           // Random random = new Random();
            for (int i = 1; i <= 30; i++)
            {

                context.Rooms.Add(new Models.Room

                {
                    RoomID = i,
                    HotelID = random.Next(1, 18),
                    TypeID = random.Next(1, 4),
                    Status = "Available"


                });

            }


            for (int i = 1; i <= 40; i++)
            {
                context.Bookings.Add(new Models.Booking
                {
                    BookingID = i,
                    RoomID = random.Next(1, 15),
                    GuestID = random.Next(1, 25),
                    CheckinTime = DateTime.Now,
                    CheckoutTime = DateTime.Now,
                    TotalPrice = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length))


                });


            }




            for (int i = 1; i <= 40; i++)
            {
                context.Payments.Add(new Models.Payment
                {
                    PaymentID=i,
                    BookingID = random.Next(1, 15),
                    Amount = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length)),
                    PaymentDate = DateTime.Now,
                    PaymentMethod = Guid.NewGuid().ToString().Substring(0, Math.Min(10, Guid.NewGuid().ToString().Length))




                });


            }




        }
    }
    }

