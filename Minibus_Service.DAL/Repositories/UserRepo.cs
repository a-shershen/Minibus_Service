using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Repositories
{
    class UserRepo:Interfaces.IGenericRepo<User>
    {
        private DbCustomContext.CustomContext db;

        public UserRepo(DbCustomContext.CustomContext db)
        {
            this.db = db;
        }

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            var item = Read(i => i.Id == id);

            if (item != null)
            {
                db.Users.Remove(item);
            }
        }

        public IEnumerable<User> GetAll(Func<User, bool> predicate = null)
        {
            if (predicate != null)
            {
                return db.Users.Where(predicate).AsEnumerable();
            }
            else
            {
                return db.Users.AsEnumerable();
            }
        }

        public User Read(Func<User, bool> predicate)
        {
            return db.Users.FirstOrDefault(predicate);
        }

        public void Update(User item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
