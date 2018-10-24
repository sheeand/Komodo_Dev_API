using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Komodo_Dev_Data.DevData;

namespace Komodo_Dev__API.Models.Devs
{
    public class DevCreateModel
    {
        // These are the columns that will be filled by the posted data
        // These will be exposed in the sample JSON in Postman
        public string Name { get; set; }
        public DateTimeOffset HireDate { get; set; }
        public Proficiency ProficiencyLevel { get; set; }
    }
}