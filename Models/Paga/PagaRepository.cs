using EFCore.BulkExtensions;
using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Paga
{
    public class PagaRepository : GenericRepository<Data.Paga>, IPagaRepository
    {
        public PagaRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IList<Data.Paga>> BulkInsertPaga(IList<Data.Paga> pagat)
        {
            await context.BulkInsertAsync(pagat);

            await context.SaveChangesAsync();
            return pagat;
        }

    }
}
