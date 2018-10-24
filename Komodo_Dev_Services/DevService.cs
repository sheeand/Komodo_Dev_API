using Komodo_Dev__API.Data;
using Komodo_Dev__API.Models;
using Komodo_Dev__API.Models.Devs;
using Komodo_Dev_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Dev_Services
{
    public class DevService
    {
        private readonly Guid _userId;

        //Empty constructor
        public DevService(Guid Id)
        {
            _userId = Id;
        }

        public bool Create(DevCreateModel model)
        {
            // Object Initialization Syntax 
            var entity = new DevData()
            {
                Name = model.Name,
                HireDate = model.HireDate,
                ProficiencyLevel = model.ProficiencyLevel
            };


            using (var ctx = new ApplicationDbContext())
            {
                ctx.Developers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool Edit(DevEditModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Developers
                        .Single(e => e.DevId == model.DevId); // && e.OwnerId == _userId

                entity.Name = model.Name;
                entity.HireDate = model.HireDate;
                entity.ProficiencyLevel = model.ProficiencyLevel;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public bool GetAll(DevGetAllModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int userId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Developers
                        .Single(e => e.DevId == userId); // && e.OwnerId == _userId

                ctx.Developers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
