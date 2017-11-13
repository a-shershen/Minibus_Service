using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.NInjectInfrastructure
{
    public class NIModule:Ninject.Modules.NinjectModule
    { 
        private string connString;

        public NIModule(string connString)
        {
            this.connString = connString;
        }

        public override void Load()
        {
            Bind<DAL.Interfaces.IUnitOfWork>().To<DAL.DbWork.DbWork>().WithConstructorArgument(connString);
        }

    }
}
