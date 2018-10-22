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

        public bool Create(DevCreate model)
        {
            //throw new NotImplementedException();

            // Object Initialization Syntax 
            var entity = new Dev()
            {
                Name = model.Name,
                HireDate = model.HireDate,
                ProficiencyLevel = model.ProficiencyLevel
            };


            using (var ctx = new ApplicationDbContext())
            {
                ctx.Dev.Create();
                return ctx.SaveChanges() == 1;
            }

        }

        public bool Edit(DevCreate model)
        {
            throw new NotImplementedException();
        }

        public bool GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public bool GetAll(DevCreate model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int userId)
        {
            throw new NotImplementedException();
        }

    }
}
