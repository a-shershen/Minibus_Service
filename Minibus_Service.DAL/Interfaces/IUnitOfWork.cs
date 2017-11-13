using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepo<Client> ClientRepo { get; }
        IGenericRepo<Order> OrderRepo { get; }
        IGenericRepo<Role> RoleRepo { get; }
        IGenericRepo<User> UserRepo { get; }
        IGenericRepo<Voyage> VoyageRepo { get; }

        void Save();
    }
}
