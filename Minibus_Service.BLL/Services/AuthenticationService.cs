using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Services
{
    public class AuthenticationService:Interfaces.IAuthenticationService
    {
        private DAL.Interfaces.IUnitOfWork db;

        public AuthenticationService(DAL.Interfaces.IUnitOfWork db)
        {
            this.db = db;
        }

        public bool IsPasswordTrue(string login, string password)
        {
            var user = db.UserRepo.Read(u => u.Login == login && u.Password == HashLib.LIB.ShaHash.GetHash(password));

            if(user!=null)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
