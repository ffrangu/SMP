using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Punetori
{
    public class PunetoriRepository :GenericRepository<Data.Punetori>, IPunetoriRepository
    {

        public PunetoriRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
