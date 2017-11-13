using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.DAL.Interfaces;
using Minibus_Service.DAL.Models;

namespace Minibus_Service.DAL.DbWork
{
    public class DbWork:IUnitOfWork
    {
        private DbCustomContext.CustomContext db;

        public DbWork(string connectionString)
        {
            db = new DbCustomContext.CustomContext(connectionString);
        }

        private IGenericRepo<Client> clientRepo;
        private IGenericRepo<Order> orderRepo;
        private IGenericRepo<Role> roleRepo;
        private IGenericRepo<User> userRepo;
        private IGenericRepo<Voyage> voyageRepo;

        public IGenericRepo<Client> ClientRepo
        {
            get
            {
                if (clientRepo == null)
                {
                    clientRepo = new Repositories.ClientRepo(db);
                }

                return clientRepo;
            }
        }

        public IGenericRepo<Order> OrderRepo
        {
            get
            {
                if(orderRepo == null)
                {
                    orderRepo = new Repositories.OrderRepo(db);
                }

                return orderRepo;
            }
        }

        public IGenericRepo<Role> RoleRepo
        {
            get
            {
                if(roleRepo==null)
                {
                    roleRepo = new Repositories.RoleRepo(db);
                }

                return roleRepo;
            }
        }

        public IGenericRepo<User> UserRepo
        {
            get
            {
                if(userRepo == null)
                {
                    userRepo = new Repositories.UserRepo(db);
                }

                return userRepo;
            }
        }

        public IGenericRepo<Voyage> VoyageRepo
        {
            get
            {
                if(voyageRepo == null)
                {
                    voyageRepo = new Repositories.VoyageRepo(db);
                }

                return voyageRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DbWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
