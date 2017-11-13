using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Mappers
{
    static class FromBllToDal
    {
        public static DAL.Models.Client ToDal(this Models.Client client)
        {
            return new DAL.Models.Client
            {
                Id = client.Id,
                PhoneNumber = client.PhoneNumber
            };
        }

        public static DAL.Models.Order ToDal(this Models.Order order)
        {
            return new DAL.Models.Order
            {
                Address = order.Address,
                ClientId = order.ClientId,
                Id = order.Id,
                VoyageId = order.VoyageId
            };
        }

        public static DAL.Models.Role ToDal(this Models.Role role)
        {
            return new DAL.Models.Role
            {
                Id = role.Id,
                RoleName = role.RoleName
            };
        }

        public static DAL.Models.User ToDal(this Models.User user)
        {
            return new DAL.Models.User
            {
                Id = user.Id,
                Login = user.Login,
                Password = user.Password,
                RoleId = user.RoleId
            };
        }

        public static DAL.Models.Voyage ToDal(this Models.Voyage v)
        {
            return new DAL.Models.Voyage
            {
                ArrivalCity = v.ArrivalCity,
                DateTime = v.DateTime,
                DepartureCity = v.DepartureCity,
                DriverId = v.DriverId,
                Id = v.Id,
                MaxSeatCount = v.MaxSeatCount
            };
        }
    }
}
