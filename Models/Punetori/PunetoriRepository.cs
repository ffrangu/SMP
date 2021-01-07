using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<SelectList> PunetoretSelectList(int? KompaniaId, string Role)
        {
            var punetoret = await GetPuntor();
            var filteredPuntore = new List<Data.Punetori>();
            var returnItems = new List<Data.Punetori>();
            if(Role == "HR")
            {
                filteredPuntore = punetoret.Where(q => q.KompaniaId == KompaniaId).ToList();

                foreach (var item in filteredPuntore)
                {
                    returnItems.Add(new Data.Punetori { Id = item.Id, Emri = item.Emri.ToUpper(), Mbiemri = item.Mbiemri.ToUpper() });
                }
            }
            else
            {
                foreach (var item in punetoret)
                {
                    returnItems.Add(new Data.Punetori { Id = item.Id, Emri = item.Emri.ToUpper(), Mbiemri = item.Mbiemri.ToUpper(),Email = item.Emri.ToUpper() + " " + item.Mbiemri.ToUpper() });
                }
            }

            return new SelectList(returnItems, "Id", "Email");

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

        public async Task<IEnumerable<Data.Punetori>> Search(string value)
        {
            var search = await context.Punetori.Include(x => x.Departamenti)
                .Include(x => x.Kompania)
                .Where(x => x.Emri.Contains(value) || x.Mbiemri.Contains(value) || x.Kompania.Emri.Contains(value)).ToListAsync();

            return search;
        }
    }
}
