using Komodo_Dev__API.Data;
using Komodo_Dev__API.Models.Teams;
using Komodo_Dev_Data;
using Komodo_Dev_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Services
{
    public class TeamService : ITeamService
    {
        private readonly Guid _userId;

        //Empty constructor
        public TeamService(Guid Id)
        {
            _userId = Id;
        }

        public bool Create(TeamCreateModel model)
        {
            // Object Initialization Syntax 
            var entity = new TeamData()
            {
                Name = model.Name
            };


            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool Edit(TeamEditModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Teams
                        .Single(e => e.TeamId == model.TeamId); // && e.OwnerId == _userId

                entity.Name = model.Name;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool Delete(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Teams
                        .Single(e => e.TeamId == teamId); // && e.OwnerId == _userId

                ctx.Teams.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
