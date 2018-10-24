using Komodo_Dev__API.Models.Teams;
using Komodo_Dev_Interfaces;
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
    [RoutePrefix("api/Team")]
    public class TeamController : ApiController
    {
        private ITeamService _teamService;

        // This is the constructor for normal use
        public TeamController()
        {
            _teamService = LocalTeamService();
        }

        // This is the overload mock constructor for unit tests
        public TeamController(TeamService mockService)
        {
            _teamService = mockService;
        }

        // Helper method
        private ITeamService LocalTeamService()
        {
            var id = Guid.Parse(User.Identity.GetUserId());
            return new TeamService(id);
        }

        // endpoint
        [Route("Create")]
        public IHttpActionResult Create(TeamCreateModel model) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Instantiate a dev service object
            var service = _teamService;

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
        public IHttpActionResult Put(TeamEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = LocalTeamService();

            if (!service.Edit(model))
            {
                return InternalServerError();
            }

            return Ok(model);
        }

        // endpoint
        public IHttpActionResult Delete(int id) // This will be the /number at the end of the url (if named "id")
        {
            var service = LocalTeamService();

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
