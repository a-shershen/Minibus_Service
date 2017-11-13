using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Minibus_Service.DAL.DbCustomContext
{
    class DbInitializer:DropCreateDatabaseIfModelChanges<DbCustomContext.CustomContext>
    {
        protected override void Seed(DbCustomContext.CustomContext context)
        {
            context.Roles.Add(new Models.Role
            {
                RoleName = "operator"
            });

            context.Roles.Add(new Models.Role
            {
                RoleName = "driver"
            });

            context.SaveChanges();

            var roleId = context.Roles.FirstAsync(r => r.RoleName == "operator").Id;

            context.Users.Add(new Models.User
            {
                Login = "Operator",
                Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3", //sha hash
                RoleId = roleId
            });

            context.SaveChanges();
        }
    }
}
