using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Interfaces
{
    interface IAuthenticationService
    {
        bool IsPasswordTrue(string login, string password);
    }
}
