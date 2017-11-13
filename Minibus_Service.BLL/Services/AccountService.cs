using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.BLL.Models;
using Minibus_Service.BLL.Mappers;

namespace Minibus_Service.BLL.Services
{
    public class AccountService:Interfaces.IAccountService
    {
        private DAL.Interfaces.IUnitOfWork db;

        public AccountService(DAL.Interfaces.IUnitOfWork db)
        {
            this.db = db;
        }

        public int GetRoleIdByRoleName(string roleName)
        {
            return db.RoleRepo.Read(r => r.RoleName == roleName).Id;
        }

        public string GetRoleNameByRoleIs(int id)
        {
            return db.RoleRepo.Read(r => r.Id == id).RoleName;
        }

        public int GetUserIdByName(string userName)
        {
            return db.UserRepo.Read(u => u.Login == userName).Id;
        }

        public string GetUserNameById(int id)
        {
            return db.UserRepo.Read(u => u.Id == id).Login;
        }

        public bool IsUserInRole(string userName, string roleName)
        {
            var userRole = db.UserRepo.Read(u => u.Login == userName && u.Role.RoleName == roleName);

            if(userRole != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterNewUser(User user)
        {
            db.UserRepo.Create(user.ToDal());
            db.Save();
        }
    }
}
