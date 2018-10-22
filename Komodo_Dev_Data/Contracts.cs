using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Data
{
    public class Contracts
    {
        ///TODO: Add keyword virtual to make foreign keys
        public int ContractId { get; set; }
        public int DevId { get; set; }
        public int TeamId { get; set; }
    }
}
