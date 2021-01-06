using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using SMP.Data;
using SMP.Models.Kompania;
using SMP.ViewModels.Paga;
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

        public async Task<bool> IsPagaInserted(int KompaniaId, int Viti, int Muaji, string role)
        {
            if(role == "HR")
            {
                return await context.Paga.AnyAsync(q => q.Punetori.KompaniaId == KompaniaId && q.Viti == Viti && q.Muaji == Muaji);

            }
            else
            {
                return await context.Paga.AnyAsync(q => q.KompaniaId == KompaniaId && q.Viti == Viti && q.Muaji == Muaji);
            }
        }

        public async Task KompaniaSubTreeAsync(IEnumerable<Data.Kompania> companies, Data.Kompania company, IList<Data.Punetori> punetoret)
        {
            var subCompanies = companies.Where(q => q.ParentId == company.Id);

            foreach (var item in subCompanies)
            {
                var punetoris = await context.Punetori.Where(q => q.KompaniaId == item.Id).Include(q => q.Grada).ToListAsync();

                foreach (var punetori in punetoris)
                {
                    punetoret.Add(punetori);
                }

                await KompaniaSubTreeAsync(companies, item, punetoret);
            }
        }

        public async Task<IList<Data.Punetori>> GetPunetoret(int KompaniaId)
        {
            var kompania = await context.Kompania.Where(q=>q.Id == KompaniaId).ToListAsync();
            var kompanite = await context.Kompania.ToListAsync();
            IList<Data.Punetori> punetoret = new List<Data.Punetori>();

            foreach (var item in kompania)
            {
                var punetoris = await context.Punetori.Where(q => q.KompaniaId == item.Id).Include(q=>q.Grada).ToListAsync();


                foreach (var punetori in punetoris)
                {
                    punetoret.Add(punetori);
                }

                await KompaniaSubTreeAsync(kompanite, item, punetoret);
            }

            return punetoret;
        }

        public async Task<decimal> Tatimi(decimal paganeto, bool primare)
        {
            decimal tatimi = 0m;

            var vleratTatimore = await context.Tatimi.FirstOrDefaultAsync();

            decimal perqindja1 = 0m;
            decimal perqindja2 = 0m;
            decimal perqindja3 = 0m;
            decimal perqindja4 = 0m;

            if (primare)
            {
                if (paganeto < vleratTatimore.VleraPare)
                {
                    perqindja1 = 0m;
                }
                if (paganeto > vleratTatimore.VleraPare && paganeto < vleratTatimore.VleraDyte)
                {
                    perqindja2 = (paganeto - vleratTatimore.VleraPare) * (vleratTatimore.PerqindjaPare / 100);
                }
                else if (paganeto > vleratTatimore.VleraPare && paganeto > vleratTatimore.VleraDyte)
                {
                    perqindja2 = (vleratTatimore.VleraDyte - vleratTatimore.VleraPare) * (vleratTatimore.PerqindjaPare / 100);
                }
                if (paganeto > vleratTatimore.VleraDyte && paganeto < vleratTatimore.VleraTrete)
                {
                    perqindja3 = (paganeto - vleratTatimore.VleraDyte) * (vleratTatimore.PerqindjaDyte / 100);
                }
                else if (paganeto > vleratTatimore.VleraDyte && paganeto > vleratTatimore.VleraTrete)
                {
                    perqindja3 = (vleratTatimore.VleraTrete - vleratTatimore.VleraDyte) * (vleratTatimore.PerqindjaDyte / 100);
                    perqindja4 = (paganeto - vleratTatimore.VleraTrete) * (vleratTatimore.PerqindjaTrete / 100);
                }
            }
            else
            {
                var tatimi_10 = paganeto * (vleratTatimore.PerqindjaTrete / 100);
                perqindja4 = tatimi_10;
            }

            tatimi = perqindja1 + perqindja2 + perqindja3 + perqindja4;

            return tatimi;
        }

        public async Task<List<PagaViewModel>> GetPagat(string role, int? KompaniaId)
        {
            var pagat = new List<PagaViewModel>();

            if (role == "Administrator")
            {
                var pagatGrouped = await context.Paga.Include(q => q.Kompania).GroupBy(q => new { q.Viti, q.Muaji, q.KompaniaId }).ToListAsync();
                pagat = (from p in pagatGrouped
                         select new PagaViewModel
                         {
                             Muaji = p.FirstOrDefault().Muaji,
                             Viti = p.FirstOrDefault().Viti,
                             Kompania = p.FirstOrDefault().Kompania.Emri,
                             Data = p.FirstOrDefault().DataEkzekutimit.Day + "/" + p.FirstOrDefault().DataEkzekutimit.Month + "/" + p.FirstOrDefault().DataEkzekutimit.Year,
                             Pershkrimi = p.FirstOrDefault().Pershkrimi
                         }).ToList();
            }
            else
            {
                var pagatGrouped = await context.Paga.Where(q => q.KompaniaId == KompaniaId).Include(q => q.Kompania).GroupBy(q => new { q.Viti, q.Muaji, q.KompaniaId }).ToListAsync();

                pagat = (from p in pagatGrouped
                         select new PagaViewModel
                         {
                             Muaji = p.FirstOrDefault().Muaji,
                             Viti = p.FirstOrDefault().Viti,
                             Kompania = p.FirstOrDefault().Kompania.Emri,
                             Data = p.FirstOrDefault().DataEkzekutimit.Day + "/" + p.FirstOrDefault().DataEkzekutimit.Month + "/" + p.FirstOrDefault().DataEkzekutimit.Year,
                             Pershkrimi = p.FirstOrDefault().Pershkrimi
                         }).ToList();
            }

            return pagat;
        }
    }
}
