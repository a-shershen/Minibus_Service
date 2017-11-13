using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Interfaces
{
    interface IOrderService
    {
        void AddNewOrder(Models.Order order);
    }
}
