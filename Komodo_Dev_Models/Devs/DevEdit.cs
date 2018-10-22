using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Komodo_Dev_Data.Devs;

namespace Komodo_Dev__API.Models.Devs
{
    public class DevEdit
    {
        public int DevId { get; set; }
        public string Name { get; set; }
        public DateTimeOffset HireDate { get; set; }
        public Proficiency ProficiencyLevel { get; set; }
    }
}