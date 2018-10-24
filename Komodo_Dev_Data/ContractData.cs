using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Data
{
    public class ContractData
    {
        ///TODO: Add keyword virtual to make foreign keys
        [Key]
        public int ContractId { get; set; }
        public int DevId { get; set; }
        public int TeamId { get; set; }
    }
}
