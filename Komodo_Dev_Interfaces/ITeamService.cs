using Komodo_Dev__API.Models.Teams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Interfaces
{
    public interface ITeamService
    {
        bool Create(TeamCreateModel model);
        bool Edit(TeamEditModel model);
        bool Delete(int teamId);
    }
}
