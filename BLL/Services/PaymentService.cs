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
   public  class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<PaymentDTO>>(data);
            return mapped;
        }


        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory.PaymentData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();

            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<PaymentDTO>(data);
            return mapped;
        }



        public static Payment Add(PaymentDTO c)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PaymentDTO, Payment>();
            });

            var mapper = new Mapper(config);
            var data = mapper.Map<Payment>(c);

            return DataAccessFactory.PaymentData().Create(data);
        }

        public static Payment Update(PaymentDTO c)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PaymentDTO, Payment>();
            });

            var mapper = new Mapper(config);
            var updatedData = mapper.Map<Payment>(c);
            return DataAccessFactory.PaymentData().Update(updatedData);
        }

       
    }
}
