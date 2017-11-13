using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Models
{
    public class Voyage
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public int DriverId { get; set; }

        public string DepartureCity { get; set; }

        public string ArrivalCity { get; set; }

        public int MaxSeatCount { get; set; }
    }
}
