using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Repositories
{
    class VoyageRepo:Interfaces.IGenericRepo<Voyage>
    {
        private DbCustomContext.CustomContext db;

        public VoyageRepo(DbCustomContext.CustomContext db)
        {
            this.db = db;
        }

        public void Create(Voyage item)
        {
            db.Voyages.Add(item);
        }

        public void Delete(int id)
        {
            var item = Read(i => i.Id == id);

            if (item != null)
            {
                db.Voyages.Remove(item);
            }
        }

        public IEnumerable<Voyage> GetAll(Func<Voyage, bool> predicate = null)
        {
            if (predicate != null)
            {
                return db.Voyages.Where(predicate).AsEnumerable();
            }
            else
            {
                return db.Voyages.AsEnumerable();
            }
        }

        public Voyage Read(Func<Voyage, bool> predicate)
        {
            return db.Voyages.FirstOrDefault(predicate);
        }

        public void Update(Voyage item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
