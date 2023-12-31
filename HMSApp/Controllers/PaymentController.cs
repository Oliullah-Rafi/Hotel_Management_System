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
    public class PaymentController : ApiController
    {

        [HttpGet]
        [Route("api/Payments/all")]
        public HttpResponseMessage Payments()
        {
            try
            {
                var data = PaymentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Payments/{id}")]
        public HttpResponseMessage Get(int id)
        {

            try
            {
                var data = PaymentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/Payments/create")]
        public HttpResponseMessage Create(PaymentDTO obj)
        {
            try
            {
                var data = PaymentService.Add(obj);

                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/Payments/update/{id}")]
        public HttpResponseMessage Update(PaymentDTO obj)
        {

            try
            {
                var updatedData = PaymentService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, updatedData);

            }

            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}
