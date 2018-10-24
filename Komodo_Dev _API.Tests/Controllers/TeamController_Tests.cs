using System;
using System.Web.Http;
using Komodo_Dev__API.Controllers;
using Komodo_Dev__API.Models.Teams;
using Komodo_Dev_Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Dev__API.Tests.Controllers
{
    [TestClass]
    public class TeamController_Tests
    {
        private static TeamService _mockService;

        //public TeamController MockController(TeamService _MockService)
        //{
        //    // this will be the dependancy being injected into the controller
        //    _mockService = _MockService;
        //    return null;
        //}

        TeamController MockController = new TeamController(_mockService);
        TeamCreateModel testModel = new TeamCreateModel
        {
            TeamId = 1,
            Name = "Test Name"
        };


        [TestMethod]
        public void Teams_AddNewTeam_IsBeingAdded()
        {



            // Arrange

            // Act 

            var x = MockController.Create(testModel);

            // Assert
            Assert.IsNotNull(x);




        }

        public bool Delete(int teamId)
        {
            throw new NotImplementedException();
        }

        public bool Edit(TeamEditModel model)
        {
            throw new NotImplementedException();
        }
    }
}
