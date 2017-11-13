using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.DAL.Models
{
    public class User
    {
        public User()
        {
            Voyages = new List<Voyage>();
        }

        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual ICollection<Voyage> Voyages { get; set; }
    }
}
