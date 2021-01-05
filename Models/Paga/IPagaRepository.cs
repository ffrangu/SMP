using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Paga
{
    public interface IPagaRepository : IGenericRepository<Data.Paga>
    {
        Task<IList<Data.Paga>> BulkInsertPaga(IList<Data.Paga> pagat);
    }
}
