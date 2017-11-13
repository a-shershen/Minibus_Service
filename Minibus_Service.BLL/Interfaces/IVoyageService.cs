using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minibus_Service.BLL.Interfaces
{
    interface IVoyageService
    {
        void AddNewVoyage(Models.Voyage voyage);

        IEnumerable<Models.Voyage> GetAllNextVoyages();

        int FreeSeats(int voyageId);
    }
}
