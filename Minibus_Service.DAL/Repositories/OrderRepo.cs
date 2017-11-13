using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Repositories
{
    class OrderRepo:Interfaces.IGenericRepo<Order>
    {
        private DbCustomContext.CustomContext db;

        public OrderRepo(DbCustomContext.CustomContext db)
        {
            this.db = db;
        }

        public void Create(Order item)
        {
            db.Orders.Add(item);
        }

        public void Delete(int id)
        {
            var item = Read(i => i.Id == id);

            if (item != null)
            {
                db.Orders.Remove(item);
            }
        }

        public IEnumerable<Order> GetAll(Func<Order, bool> predicate = null)
        {
            if (predicate != null)
            {
                return db.Orders.Where(predicate).AsEnumerable();
            }
            else
            {
                return db.Orders.AsEnumerable();
            }
        }

        public Order Read(Func<Order, bool> predicate)
        {
            return db.Orders.FirstOrDefault(predicate);
        }

        public void Update(Order item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
