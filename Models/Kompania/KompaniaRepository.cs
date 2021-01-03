using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Kompania
{
    public class KompaniaRepository : GenericRepository<Data.Kompania>, IKompaniaRepository
    {
        public KompaniaRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
