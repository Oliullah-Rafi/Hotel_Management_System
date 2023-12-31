using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
   public class BookingService
    {
        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory.BookingData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<BookingDTO>>(data);
            return mapped;
        }


        public static BookingDTO Get(int id)
        {
            var data = DataAccessFactory.BookingData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BookingDTO>(data);
            return mapped;
        }



        public static Booking Add(BookingDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingDTO, Booking>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Booking>(c);

            return DataAccessFactory.BookingData().Create(data);
        }

        public static Booking Update(BookingDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingDTO, Booking>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Booking>(c);
            return DataAccessFactory.BookingData().Update(updatedData);
        }

       
    }
}
