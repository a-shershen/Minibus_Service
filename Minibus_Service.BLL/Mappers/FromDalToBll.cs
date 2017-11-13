using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Mappers
{
    public static class FromDalToBll
    {
        public static Models.Client ToBll(this DAL.Models.Client model)
        {
            return new Models.Client
            {
                Id = model.Id,
                PhoneNumber = model.PhoneNumber
            };
        }

        public static Models.Order ToBll(this DAL.Models.Order model)
        {
            return new Models.Order
            {
                Address = model.Address,
                ClientId = model.ClientId,
                Id = model.Id,
                VoyageId = model.VoyageId
            };
        }

        public static Models.Role ToBll(this DAL.Models.Role role)
        {
            return new Models.Role
            {
                Id = role.Id,
                RoleName = role.RoleName
            };
        }

        public static Models.User ToBll(this DAL.Models.User user)
        {
            return new Models.User
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                RoleId = user.RoleId
            };
        }

        public static Models.Voyage ToBll(this DAL.Models.Voyage v)
        {
            return new Models.Voyage
            {
                ArrivalCity = v.ArrivalCity,
                DateTime = v.DateTime,
                DepartureCity = v.DepartureCity,
                DriverId = v.DriverId,
                Id = v.Id,
                MaxSeatCount = v.MaxSeatCount
            };
        }

        public static IEnumerable<Models.Voyage> ToBll(this IEnumerable<DAL.Models.Voyage> vs)
        {
            List<Models.Voyage> list = new List<Models.Voyage>();

            foreach(var v in vs)
            {
                list.Add(v.ToBll());
            }

            return list.AsEnumerable();
        }
    }
}
