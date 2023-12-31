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
  public  class GuestService
    {

        public static List<GuestDTO> Get()
        {
            var data = DataAccessFactory.GuestData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Guest, GuestDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<GuestDTO>>(data);
            return mapped;
        }


        public static GuestDTO Get(int id)
        {
            var data = DataAccessFactory.GuestData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Guest, GuestDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GuestDTO>(data);
            return mapped;
        }



        public static Guest Add(GuestDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<GuestDTO, Guest>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Guest>(c);

            return DataAccessFactory.GuestData().Create(data);
        }

        public static Guest Update(GuestDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<GuestDTO, Guest>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Guest>(c);
            return DataAccessFactory.GuestData().Update(updatedData);
        }
    }
}
