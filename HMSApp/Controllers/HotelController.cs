using BLL.DTOs;
using BLL.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMSApp.Controllers
{
    public class HotelController : ApiController
    {
        [HttpGet]
        [Route("api/hotels/all")]
        public HttpResponseMessage Hotels()
        {
            try
            {
                var data = HotelService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/hotels/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = HotelService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/hotels/create")]
        public HttpResponseMessage Create(HotelDTO obj)
        {
            try
            {
                var data = HotelService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/hotels/update/{id}")]
        public HttpResponseMessage Update(HotelDTO obj)
        {

            try
            {
                var updatedData = HotelService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }




    }
}

