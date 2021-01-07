using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Bonuset
{
    public class BonusetRepository :GenericRepository<Data.Bonuset>, IBonusetRepository
    {
        public BonusetRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
