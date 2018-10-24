using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Data
{
    public class DevData // This class type is referenced in DbSet<>() in IdentityModels.cs
    {
        public enum Proficiency
        {
            Entry,
            Mid,
            Junior,
            Senior,
            Principle
        }

        [Key] // This means it's the primary key
        public int DevId { get; set; }

        [Required]
        public string Name { get; set; }
        public DateTimeOffset HireDate { get; set; }
        public Proficiency ProficiencyLevel { get; set; }
    }
}
