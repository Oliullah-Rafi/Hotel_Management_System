using BLL.Services;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace HMSApp.Controllers
{
    public class RoomTypeController : ApiController
    {
       

        [HttpGet]
        [Route("api/RoomTypes/all")]
        public HttpResponseMessage RoomTypes()
        {
            try
            {
                var data = RoomTypeTypeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/RoomTypes/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = RoomTypeTypeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/RoomTypes/create")]
        public HttpResponseMessage Create(RoomTypeDTO obj)
        {
            try
            {
                var data = RoomTypeTypeService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/RoomTypes/update/{id}")]
        public HttpResponseMessage Update(RoomTypeDTO obj)
        {

            try
            {
                var updatedData = RoomTypeTypeService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
