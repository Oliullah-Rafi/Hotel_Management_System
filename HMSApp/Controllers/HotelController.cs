using BLL.Services;
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
        [Route("api/hotels")]
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
    }
}
