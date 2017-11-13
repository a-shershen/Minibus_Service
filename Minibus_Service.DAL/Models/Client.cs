using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.DAL.Models
{
    public class Client
    {
        public Client()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
