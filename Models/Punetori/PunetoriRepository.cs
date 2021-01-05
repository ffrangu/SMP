using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Data.Punetori>> GetPuntor()
        {


            var punetoret = await context.Punetori.Include(x => x.Departamenti)
                .Include(x => x.Kompania)
                .Include(x=>x.Komuna)
                .Include(x=>x.Pozita)
                .Include(x=>x.Grada)
                .Include(x=>x.Banka)
                .OrderByDescending(x => x.Id).ToListAsync();

            return punetoret;
        }

        public async Task<Data.Punetori> GetPuntoriDetails(int? id)
        {
            var puntoriDetails = await context.Punetori.Include(x => x.Departamenti)
                .Include(x => x.Kompania)
                .Include(x => x.Komuna)
                .Include(x => x.Pozita)
                .Include(x => x.Grada)
                .Include(x => x.Banka).Where(x=>x.Id == id).FirstOrDefaultAsync();

            return puntoriDetails;
        }
    }
}
