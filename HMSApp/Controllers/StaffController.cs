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
    public class StaffController : ApiController
    {

        [HttpGet]
        [Route("api/Staffs/all")]
        public HttpResponseMessage Staffs()
        {
            try
            {
                var data = StaffService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Staffs/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = StaffService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Staffs/create")]
        public HttpResponseMessage Create(StaffDTO obj)
        {
            try
            {
                var data = StaffService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Staffs/update/{id}")]
        public HttpResponseMessage Update(StaffDTO obj)
        {

            try
            {
                var updatedData = StaffService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
