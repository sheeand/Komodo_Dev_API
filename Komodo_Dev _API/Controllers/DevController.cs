using Komodo_Dev__API.Models.Devs;
using Komodo_Dev_Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Komodo_Dev__API.Controllers
{
    [RoutePrefix("api/Dev")]
    public class DevController : ApiController
    {

        // Method that returns the specific dev service 
        // passing in the associated parameter
        private DevService CreateDev()
        {
            //var id = User.Identity.GetUserId();
            return new DevService();
        }

        // endpoint
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Create(DevCreate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Instantiate the specific dev service
            var service = CreateDev();

            // Call the appropriate method 
            // passing in the appropiate model
            if (!service.Create(model))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
