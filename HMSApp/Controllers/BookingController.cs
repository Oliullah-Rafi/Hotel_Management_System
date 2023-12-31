using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HMSApp.Controllers
{
    public class BookingController : ApiController
    {
        [HttpGet]
        [Route("api/Bookings/all")]
        public HttpResponseMessage Bookings()
        {
            try
            {
                var data = BookingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Bookings/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = BookingService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Bookings/create")]
        public HttpResponseMessage Create(BookingDTO obj)
        {
            try
            {
                var data = BookingService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Bookings/update/{id}")]
        public HttpResponseMessage Update(BookingDTO obj)
        {

            try
            {
                var updatedData = BookingService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
