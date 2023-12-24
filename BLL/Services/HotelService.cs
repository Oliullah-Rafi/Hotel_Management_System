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

    }
}
