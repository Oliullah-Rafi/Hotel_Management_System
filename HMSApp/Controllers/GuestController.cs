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
    public class GuestController : ApiController
    {

        [HttpGet]
        [Route("api/Guests/all")]
        public HttpResponseMessage Guests()
        {
            try
            {
                var data = GuestService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Guests/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = GuestService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Guests/create")]
        public HttpResponseMessage Create(GuestDTO obj)
        {
            try
            {
                var data = GuestService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Guests/update/{id}")]
        public HttpResponseMessage Update(GuestDTO obj)
        {

            try
            {
                var updatedData = GuestService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



        [HttpGet]
        [Route("api/GuestBookingDetails/{id}")]
        public HttpResponseMessage BookingSearch(int id)
        {

            try
            {
                var updatedData = HotelService.BookingSearch(id);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
       
       
    }
}
