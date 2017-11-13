using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minibus_Service.BLL.Models;

using Minibus_Service.BLL.Mappers;

namespace Minibus_Service.BLL.Services
{
    public class VoyageService:Interfaces.IVoyageService
    {
        private DAL.Interfaces.IUnitOfWork db;

        public VoyageService(DAL.Interfaces.IUnitOfWork db)
        {
            this.db = db;
        }

        public void AddNewVoyage(Voyage voyage)
        {
            db.VoyageRepo.Create(voyage.ToDal());
            db.Save();
        }

        public int FreeSeats(int voyageId)
        {
            return db.VoyageRepo.Read(v => v.Id == voyageId).MaxSeatCount - db.OrderRepo.GetAll(o => o.VoyageId == voyageId).Count();
        }

        public IEnumerable<Voyage> GetAllNextVoyages()
        {
            return db.VoyageRepo.GetAll(v => v.DateTime > DateTime.Now).ToBll();
        }
    }
}
