using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public int VoyageId { get; set; }

        public int ClientId { get; set; }

        public string Address { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("VoyageId")]
        public virtual Voyage Voyage { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

    }
}
