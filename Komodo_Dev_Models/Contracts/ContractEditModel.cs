using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komodo_Dev__API.Models.Contracts
{
    public class ContractEditModel
    {
        public int ContractId { get; set; }
        public int DevId { get; set; }
        public int TeamId { get; set; }
    }
}