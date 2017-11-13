using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.BLL.Models;

using Minibus_Service.BLL.Mappers;

namespace Minibus_Service.BLL.Services
{
    public class OrderService:Interfaces.IOrderService
    {
        private DAL.Interfaces.IUnitOfWork db;

        public OrderService(DAL.Interfaces.IUnitOfWork db)
        {
            this.db = db;
        }

        public void AddNewOrder(Order order)
        {
            db.OrderRepo.Create(order.ToDal());
            db.Save();
        }
    }
}
