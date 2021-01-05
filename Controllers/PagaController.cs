using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SMP.Data;
using SMP.Helpers;
using SMP.Models.Kompania;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class PagaController : BaseController
    {
        protected UserManager<ApplicationUser> userManager;
        protected RoleManager<IdentityRole> roleManager;
        public AlertService alertService { get; }

        private IKompaniaRepository kompaniaRepository;

        public PagaController(IKompaniaRepository _kompaniaRepository, RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUser> _userManager, AlertService _alertService)
        : base(_roleManager, _userManager)
        {
            alertService = _alertService;
            userManager = _userManager;
            roleManager = _roleManager;
            kompaniaRepository = _kompaniaRepository;
        }

        // GET: PagaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PagaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles = "Administrator, HR")]
        // GET: PagaController/Create
        public async Task<ActionResult> CreateAsync()
        {
            string role = User.IsInRole("HR") ? "HR" : "Administrator";

            ViewBag.KompaniaId = await kompaniaRepository.KompaniaSelectListBasedOnRole(role, user.KompaniaId);
            //ViewBag.KompaniaId = await kompaniaRepository.KompaniaSelectList(null,false,false);

            ViewBag.Muaji = new SelectList(Enumerable.Range(1, 12).Select(x =>
                                new SelectListItem()
                                {
                                    Text = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[x - 1] + " (" + x + ")",
                                    Value = x.ToString()
                                }), "Value", "Text", DateTime.Today.Month.ToString());


            ViewBag.Viti = new SelectList(Enumerable.Range(DateTime.Today.Year, 1).Select(x =>
                           new SelectListItem()
                           {
                               Text = x.ToString(),
                               Value = x.ToString()
                           }), "Value", "Text");

            return View();
        }

        // POST: PagaController/Create
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

        // GET: PagaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PagaController/Edit/5
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

        // GET: PagaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PagaController/Delete/5
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
