using Komodo_Dev__API.Models.Contracts;
using Komodo_Dev__API.Models.Teams;
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
    [RoutePrefix("api/Contract")]
    public class ContractController : ApiController
    {
        private ContractService LocalContractService()
        {
            var id = Guid.Parse(User.Identity.GetUserId());
            var contractService = new ContractService(id);
            return contractService;
        }

        // endpoint
        [Route("Create")]
        public IHttpActionResult Create(ContractCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Instantiate the specific dev service
            var service = LocalContractService();

            //Call the appropriate method
            //passing in the appropiate model
            if (!service.Create(model))
            {
                return InternalServerError();
            }

            return Ok(model);
        }

        // endpoint
        [Route("Edit")]
        public IHttpActionResult Put(ContractEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = LocalContractService();

            if (!service.Edit(model))
            {
                return InternalServerError();
            }

            return Ok(model);
        }

        // endpoint
        public IHttpActionResult Delete(int id) // This will be the /number at the end of the url (if named "id")
        {
            var service = LocalContractService();

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

    }
}
