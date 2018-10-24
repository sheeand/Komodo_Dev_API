using Komodo_Dev__API.Data;
using Komodo_Dev__API.Models.Contracts;
using Komodo_Dev_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Services
{
    public class ContractService
    {
            private readonly Guid _userId;

            //Empty constructor
            public ContractService(Guid Id)
            {
                _userId = Id;
            }

            public bool Create(ContractCreateModel model)
            {
                // Object Initialization Syntax 
                var entity = new ContractData()
                {
                    DevId = model.DevId,
                    TeamId = model.TeamId
                };


                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Contracts.Add(entity);
                    return ctx.SaveChanges() == 1;
                }
            }

            public bool Edit(ContractEditModel model)
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity =
                        ctx
                            .Contracts
                            .Single(e => e.ContractId == model.ContractId); // && e.OwnerId == _userId

                    entity.DevId = model.DevId;
                    entity.TeamId = model.TeamId;
                    return ctx.SaveChanges() == 1;
                }
            }

        public bool Delete(int contractId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Contracts
                        .Single(e => e.ContractId == contractId); // && e.OwnerId == _userId

                ctx.Contracts.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
