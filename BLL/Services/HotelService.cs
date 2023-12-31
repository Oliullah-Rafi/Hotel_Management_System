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
   public class HotelService
    {
        public static List<HotelDTO> Get()
        {
            var data = DataAccessFactory.HotelData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<HotelDTO>>(data);
            return mapped;
        }


        public static HotelDTO Get(int id)
        {
            var data = DataAccessFactory.HotelData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Hotel, HotelDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<HotelDTO>(data);
            return mapped;
        }



        public static Hotel Add(HotelDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<HotelDTO, Hotel>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Hotel>(c);

            return DataAccessFactory.HotelData().Create(data);
        }

        public static Hotel Update(HotelDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<HotelDTO, Hotel>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Hotel>(c);
            return DataAccessFactory.HotelData().Update(updatedData);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.HotelData().Delete(id);
        }
        public static BookingDTO BookingSearch(int c)
        {
            var data = DataAccessFactory.BookingData().GetBookking(c);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<BookingDTO>(data);
            return converted;
        }
    }
}
