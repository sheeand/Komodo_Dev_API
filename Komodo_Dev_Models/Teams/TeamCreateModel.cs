using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komodo_Dev__API.Models.Teams
{
    public class TeamCreateModel
    {
        public int? TeamId { get; set; } // For unit tests only
        public string Name { get; set; }
    }
}