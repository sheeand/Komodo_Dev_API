﻿using Komodo_Dev__API.Models.Devs;
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

        // Helper methods that returns the specific dev service 
        // passing in the associated parameter
        private DevService LocalDevService()
        {
            var id = Guid.Parse(User.Identity.GetUserId());
            var devService = new DevService(id);
            return devService;
        }

        // endpoint
        public IHttpActionResult Create(DevCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Instantiate the specific dev service
            var service = LocalDevService();

            //Call the appropriate method
            //passing in the appropiate model
            if (!service.Create(model))
            {
                return InternalServerError();
            }

            return Ok(model);
        }

        // endpoint
        public IHttpActionResult Put(DevEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = LocalDevService();

            if (!service.Edit(model))
            {
                return InternalServerError();
            }

            return Ok(model);
        }

        // endpoint
        public IHttpActionResult Delete(int id)
        {
            var service = LocalDevService();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!service.Delete(id))
            {
                return InternalServerError();
            }

            return Ok(id);
        }


        //public IHttpActionResult GetAll(DevGetAllModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var service = GetAllDev(model);

        //    if (!service(model))
        //    {
        //        return InternalServerError();
        //    }

        //    return Ok(model);
        //}

    }
}
