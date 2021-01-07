using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Bonuset;
using SMP.Models.Punetori;
using SMP.ViewModels.Bonuset;

namespace SMP.Controllers
{
    public class BonusetController : BaseController
    {

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IPunetoriRepository punetoriRepository;
        private IBonusetRepository bonusetRepository;

        


        public BonusetController(IPunetoriRepository _punetoriRepository, IBonusetRepository _bonusetRepository,RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager, AlertService _alertService)
        : base(_roleManager, _userManager)
        {
            alertService = _alertService;
            userManager = _userManager;
            roleManager = _roleManager;
            punetoriRepository = _punetoriRepository;
            bonusetRepository = _bonusetRepository;

        }
        // GET: BonusetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BonusetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonusetController/Create
        public async Task<ActionResult> CreateAsync()
        {
            string role = User.IsInRole("HR") ? "HR" : "Administrator";
            ViewBag.Punetori = await punetoriRepository.PunetoretSelectList(user.KompaniaId, role);

            ViewBag.Muaji = new SelectList(Enumerable.Range(1, 12).Select(x =>
                                 new SelectListItem()
                                 {
                                     Text = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[x - 1] + " (" + x + ")",
                                     Value = x.ToString()
                                 }), "Value", "Text", DateTime.Today.Month.ToString());


            ViewBag.Viti = new SelectList(Enumerable.Range(DateTime.Today.Year - 1, 2).Select(x =>
                           new SelectListItem()
                           {
                               Text = x.ToString(),
                               Value = x.ToString()
                           }), "Value", "Text", DateTime.Today.Year.ToString());

            return View();
        }

        // POST: BonusetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(BonusetCreateViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var addBonus = new Bonuset
                    {
                        Id = model.Id,
                        Muaji = model.Muaji,
                        Viti = model.Viti,
                        PunetoriId = model.PunetoriId,
                        Pershkrimi = model.Pershkrimi,
                        Vlera = model.Vlera,
                        Bruto = model.Bruto,
                        Created = DateTime.Now,
                        CreatedBy = user.UserId
                    };

                    var result =await bonusetRepository.AddAsync(addBonus);
                    alertService.Success("Bonusi u shtua me sukses!");

                    return RedirectToAction("Index");
                }
                catch (Exception)
                {

                    alertService.Danger("Diqka shkoi gabim, provoni perseri!");
                    return View(model);
                }
            }
            alertService.Information("Plotesoni te gjitha fushat!");
            return View(model);
        }

        // GET: BonusetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonusetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BonusetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonusetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
