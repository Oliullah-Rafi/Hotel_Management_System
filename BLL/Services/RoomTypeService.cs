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
   public class RoomTypeTypeService
    {
        public static List<RoomTypeDTO> Get()
        {
            var data = DataAccessFactory.RoomTypeData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RoomType, RoomTypeDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RoomTypeDTO>>(data);
            return mapped;
        }


        public static RoomTypeDTO Get(int id)
        {
            var data = DataAccessFactory.RoomTypeData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<RoomType, RoomTypeDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RoomTypeDTO>(data);
            return mapped;
        }



        public static RoomType Add(RoomTypeDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomTypeDTO, RoomType>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<RoomType>(c);

            return DataAccessFactory.RoomTypeData().Create(data);
        }

        public static RoomType Update(RoomTypeDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RoomTypeDTO, RoomType>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<RoomType>(c);
            return DataAccessFactory.RoomTypeData().Update(updatedData);
        }
    }
}
