using SMP.Data;
using SMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.ViewModels.Departamenti
{
    public class DepartamentiRepository : GenericRepository<Data.Departamenti>, IDepartamentiRepository
    {
        public DepartamentiRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
