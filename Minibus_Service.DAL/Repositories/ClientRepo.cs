using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Repositories
{
    class ClientRepo:Interfaces.IGenericRepo<Client>
    {
        private DbCustomContext.CustomContext db;

        public ClientRepo(DbCustomContext.CustomContext db)
        {
            this.db = db;
        }

        public void Create(Client item)
        {
            db.Clients.Add(item);
        }

        public void Delete(int id)
        {
            var item = Read(i => i.Id == id);

            if(item!=null)
            {
                db.Clients.Remove(item);
            }
        }

        public IEnumerable<Client> GetAll(Func<Client, bool> predicate = null)
        {
            if(predicate!=null)
            {
                return db.Clients.Where(predicate).AsEnumerable();
            }
            else
            {
                return db.Clients.AsEnumerable();
            }
        }

        public Client Read(Func<Client, bool> predicate)
        {
            return db.Clients.FirstOrDefault(predicate);
        }

        public void Update(Client item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
