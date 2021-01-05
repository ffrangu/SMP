using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Bank;
using SMP.Models.Departamenti;
using SMP.Models.Grada;
using SMP.Models.Kompania;
using SMP.Models.Pozita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Controllers
{
    public class PunetoriController : BaseController
    {

        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IPozitaRepository pozitaRepository;

        private IDepartamentiRepository departamentiRepository;

        private IKompaniaRepository kompaniaRepository;

        private IBankRepository bankaRepository;

        private IGradaRepository gradaRepository;

        public PunetoriController(IGradaRepository _gradaRepository,IPozitaRepository _pozitaRepository, IBankRepository _bankaRepository, IDepartamentiRepository _departamentiRepository, IKompaniaRepository _kompaniaRepository, RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager,
            AlertService _alertService) 
            : base(_roleManager,_userManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
            alertService = _alertService;
            pozitaRepository = _pozitaRepository;
            departamentiRepository = _departamentiRepository;
            kompaniaRepository = _kompaniaRepository;
            bankaRepository = _bankaRepository;
            gradaRepository= _gradaRepository;
        }

        // GET: PunetoriController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PunetoriController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PunetoriController/Create
        public async Task<ActionResult> CreateAsync()
        {
            ViewBag.AddError = false;
            ViewBag.KomunaId = await kompaniaRepository.LoadKomuna(null);
            ViewBag.Departamenti = await departamentiRepository.DepartamentiSelectList(null, false, false);
            ViewBag.Kompania = await kompaniaRepository.KompaniaSelectList(null, false, false);
            ViewBag.Pozita = await pozitaRepository.PozitaSelectList(null, false, false);
            ViewBag.Banka = await bankaRepository.BankaSelectList(null, false, false);
            ViewBag.Grada = await gradaRepository.GradaSelectList(null, false, false);
            return View();
        }

        // POST: PunetoriController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PunetoriController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PunetoriController/Edit/5
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

        // GET: PunetoriController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PunetoriController/Delete/5
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
