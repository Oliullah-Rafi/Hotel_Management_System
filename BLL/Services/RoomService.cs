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
    public class RoomService
    {

        public static List<RoomDTO> Get()
        {
            var data = DataAccessFactory.RoomData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RoomDTO>>(data);
            return mapped;
        }


        public static RoomDTO Get(int id)
        {
            var data = DataAccessFactory.RoomData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Room, RoomDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RoomDTO>(data);
            return mapped;
        }



        public static Room Add(RoomDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomDTO, Room>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Room>(c);

            return DataAccessFactory.RoomData().Create(data);
        }

        public static Room Update(RoomDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomDTO, Room>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Room>(c);
            return DataAccessFactory.RoomData().Update(updatedData);
        }

        public static bool Booked(int item)
        {
            return DataAccessFactory.RoomServiceData().Book(item);
        }
    }
}
