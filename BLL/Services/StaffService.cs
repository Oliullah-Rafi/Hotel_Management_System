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
   public class StaffService
    {
        public static List<StaffDTO> Get()
        {
            var data = DataAccessFactory.StaffData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Staff, StaffDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<StaffDTO>>(data);
            return mapped;
        }


        public static StaffDTO Get(int id)
        {
            var data = DataAccessFactory.StaffData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Staff, StaffDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StaffDTO>(data);
            return mapped;
        }



        public static Staff Add(StaffDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StaffDTO, Staff>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Staff>(c);

            return DataAccessFactory.StaffData().Create(data);
        }

        public static Staff Update(StaffDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StaffDTO, Staff>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Staff>(c);
            return DataAccessFactory.StaffData().Update(updatedData);
        }
    }
}
