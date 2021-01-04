using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Grada
{
    public class GradaRepository :GenericRepository<Data.Grada>, IGradaRepository
    {
        public GradaRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}
