using SMP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models.Bank
{
    public class BankRepository : GenericRepository<Data.Banka> , IBankRepository
    {

        public BankRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
