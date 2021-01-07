using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Punetori
{
    public interface IPunetoriRepository : IGenericRepository<Data.Punetori>
    {
        Task<IEnumerable<Data.Punetori>> GetPuntor();

        Task<Data.Punetori> GetPuntoriDetails(int? id);

        Task<Data.Punetori> Search(string value);

    }
}
