using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Komodo_Dev__API.Models.Contracts
{
    public class ContractCreateModel
    {
        public int DevId { get; set; }
        public int TeamId { get; set; }
    }
}