using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.DAL.Models
{
    public class Voyage
    {
        public Voyage()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int DriverId { get; set; }

        public string DepartureCity { get; set; }

        public string ArrivalCity { get; set; }

        public int MaxSeatCount { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("DriverId")]
        public virtual User Driver { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
