using SMP.ViewModels.Paga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Paga
{
    public interface IPagaRepository : IGenericRepository<Data.Paga>
    {
        Task<IList<Data.Paga>> BulkInsertPaga(IList<Data.Paga> pagat);

        Task<bool> IsPagaInserted(int KompaniaId, int Viti, int Muaji, string role);

        Task KompaniaSubTreeAsync(IEnumerable<Data.Kompania> companies, Data.Kompania company, IList<Data.Punetori> punetoret);

        Task<IList<Data.Punetori>> GetPunetoret(int KompaniaId);

        Task<decimal> Tatimi(decimal paganeto, bool primare);

        Task<List<PagaViewModel>> GetPagat(string role, int? KompaniaId);
    }
}
