using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Repositories
{
    class RoleRepo:Interfaces.IGenericRepo<Role>
    {
        private DbCustomContext.CustomContext db;

        public RoleRepo(DbCustomContext.CustomContext db)
        {
            this.db = db;
        }

        public void Create(Role item)
        {
            db.Roles.Add(item);
        }

        public void Delete(int id)
        {
            var item = Read(i => i.Id == id);

            if (item != null)
            {
                db.Roles.Remove(item);
            }
        }

        public IEnumerable<Role> GetAll(Func<Role, bool> predicate = null)
        {
            if (predicate != null)
            {
                return db.Roles.Where(predicate).AsEnumerable();
            }
            else
            {
                return db.Roles.AsEnumerable();
            }
        }

        public Role Read(Func<Role, bool> predicate)
        {
            return db.Roles.FirstOrDefault(predicate);
        }

        public void Update(Role item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
