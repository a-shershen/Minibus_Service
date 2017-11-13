using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Interfaces
{
    public interface IAccountService
    {
        int GetUserIdByName(string userName);
        int GetRoleIdByRoleName(string roleName);

        string GetUserNameById(int id);
        string GetRoleNameByRoleIs(int id);

        bool IsUserInRole(string userName, string roleName);

        void RegisterNewUser(Models.User user);
    }
}
