using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Data
{
    public class TeamData
    {
        [Key] // This means it's the primary key
        public int TeamId { get; set; }

        public string Name { get; set; }
    }
}
